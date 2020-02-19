using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

// ReSharper disable InvertIf
namespace StoneWare.Data
{
    // Author: David Bennett
    public static class EfCoreStoredProcedureExtension
    {
        public static DbCommand LoadStoredProc(this DbContext context, string storedProcName)
        {
            var cmd = context.Database.GetDbConnection().CreateCommand();

            cmd.CommandText = storedProcName;

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            return cmd;
        }

        public static DbCommand WithSqlParam(this DbCommand cmd, string paramName, object paramValue)
        {
            if (string.IsNullOrEmpty(cmd.CommandText))

                throw new InvalidOperationException(
                    "Call LoadStoredProc before using this method");

            var param = cmd.CreateParameter();

            param.ParameterName = paramName;

            param.Value = paramValue;

            cmd.Parameters.Add(param);

            return cmd;
        }

        private static List<T> MapToList<T>(this DbDataReader dr)
        {
            var objList = new List<T>();

            var props = typeof(T).GetRuntimeProperties();

            var colMapping = dr.GetColumnSchema()
                // ReSharper disable once SpecifyStringComparison
                .Where(x => props.Any(y => y.Name.ToLower() == x.ColumnName.ToLower()))
                .ToDictionary(key => key.ColumnName.ToLower());

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    // ReSharper disable once SuggestVarOrType_SimpleTypes
                    T obj = Activator.CreateInstance<T>();

                    // ReSharper disable once PossibleMultipleEnumeration
                    foreach (var prop in props)
                    {
                        var val =
                            // ReSharper disable once PossibleInvalidOperationException
                            dr.GetValue(colMapping[prop.Name.ToLower()].ColumnOrdinal.Value);

                        prop.SetValue(obj, val == DBNull.Value ? null : val);
                    }

                    objList.Add(obj);
                }
            }

            return objList;
        }


        public static async Task<List<T>> ExecuteStoredProc<T>(this DbCommand command)
        {
            await using (command)
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)

                    command.Connection.Open();

                try
                {
                    // ReSharper disable once ConvertToUsingDeclaration
                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        return reader.MapToList<T>();
                    }
                }

                finally
                {
                    command.Connection.Close();
                }
            }
        }
    }
}