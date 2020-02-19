# StoneWare

Student repo for the 6<sup>th</sup> project of [OpenClassrooms' .NET Back-End Developer path](https://openclassrooms.com/en/paths/156-back-end-developer-net), the objective
of which is to design and implement a relational database for an issue-tracking system. This project contains:
- an Entity Relationship Diagram describing the logical design of the database
- a backup of the implemented and seeded database, with stored procedures
- an ASP.NET Core project that, in the absence of data, will seed the database when run 
- an ASP.NET Core test project (along with a test table) used to verify the functionality of stored procedures
- documentation for the usage of the database's stored procedures     

To view the project:
1. Clone this repo: ``git clone https://github.com/jakarlse88/literate-octo-robot.git``
2. Using Server Management Studio, restore the ``StoneWare`` database from ``StoneWare.bak`` (requires MS SQL Server/SQL Server Express)
3. Open the ``StoneWare`` ASP.NET Core project in your IDE of choice (or use the ``dotnet CLI``), restore packages, and run either the 
main project to seed data (note that this does not currently create the stored procedures), or the test project to





