-- entity farmework removes the need to write sql manually, it allows developers to interact with the database using objects .

--why we use entity framework?---->
--without entity framework, we would have to write sql queries manually.
--more chance to error
--time consuming

--with EF----> 
--less code to write
--less chance to error
--faster development
--easy to maintain

--without EF---->
--select * from notes where id = 1
--with EF---->
--context.students.find(1)

--EF core--->
--EF core is a lightweight, extensible, and cross-platform version of Entity Framework.
--it is modern version of framework that works on windows, linux, and macOS.

--ORM---->
--ORM stands for Object-Relational Mapping
--it maps classes to database tables and to objects to rows in the database.

--coding approach---->
--code first approach--> start with writing code and then generate database from code automatically.
--database first approach--> databse is already exists,generate c# classes from database .


--db context---->
--db context is the main class that conncet your application to the database
--ex--> public dbset<students> students { get; set; }

--dbset---->
-- represents a table in the database and allows you to perform CRUD operations on that table.

--migrations---->
--migrations is used cretate and update database structure automatically .

--activity1:- what is CURD operations and HTTP methods?