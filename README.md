This is a simple ASP.NET Core MVC web application that demonstrates CRUD operations using **Dapper** and **SQL Server Management Studio**.
## 🚀 Getting Started
### Prerequisites ******************************
Make sure you have the following installed:
- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) with ASP.NET and web development tools
- Git (optional, for version control)

- ⚙️ Configuration ****************************
Update the database connection string in appsettings.json, set your SQL Server connection string:
  You can use below the create database script
  
  ***************************************************************************************************
  CREATE TABLE [dbo].[Product](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
********************************************************************************************************

▶️ Run the App ****************************
Using Visual Studio:
Open your .sln file (e.g., MyProject.sln) in Visual Studio.
Press F5 or you can start Running

Open your browser and go to: Such as
http://localhost:5000 or https://localhost:5001

🧪 Features *******************************
List all products
Create new product
Edit product
Delete product (with modal confirmation)
View product details (via popup modal)
Responsive Bootstrap UI
Server-side validation

✅ Technologies ***************************
ASP.NET Core MVC
Dapper
SQL Server Management Studio
Bootstrap 5
Entity-style validation
