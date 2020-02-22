# StoneWare
 
**The branches deliv_1, deliv_2, and deliv_3 correspond to the deliverables as outlined in the project description.**
- deliv_1 contains only the ERD
- deliv_2 contains the ERD, as well as ``.bak`` and SQL script backups of the database _sans stored procedures_
- deliv_3 contains the full project (and is equal to the master branch)

Student repo for the 6<sup>th</sup> project of [OpenClassrooms' .NET Back-End Developer path](https://openclassrooms.com/en/paths/156-back-end-developer-net), the objective
of which is to design and implement a relational database for an issue-tracking system. This project contains:
- an Entity Relationship Diagram describing the logical design of the database
- backups of the implemented and seeded database, with stored procedures
- an ASP.NET Core project that, in the absence of data, will seed the database when run 
- an ASP.NET Core test project (along with a test table) used to verify the functionality of stored procedures
- documentation for the usage of the database's stored procedures     
- documentation for tests run, in the form of a spreadsheet test table

**This project was built using SQL Server 2019, and as such compatibility with earlier versions cannot be guaranteed.** To view, clone this repo (``git clone https://github.com/jakarlse88/literate-octo-robot.git``), and choose one of the following options:

- Restore the ``StoneWare`` database from ``StoneWare.bak`` in Server Management Studio (requires  SQL Server 2019)
- Restore the ``StoneWare`` database from the SQL script in ``StoneWare.sql``
- Run the ASP.NET Core project from your IDE of choice, or using the ``dotnet cli``. This will launch an ASP.NET Core web app which automatically populates and seeds the database. The app can safely be closed once it has successfully run.








