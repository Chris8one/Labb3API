# Person Interests API

A REST API built with ASP.NET Core and Entity Framework Core. The application manages people, their interests and links connected to those interests.

This project was created as a school assignment to practise building a database-driven Web API with C#, Entity Framework Core and SQL Server.

## Features

The API can:

* Retrieve all people
* Retrieve a person by ID
* Search for people by name
* Retrieve the interests connected to a person
* Retrieve the links connected to a person
* Create a new person
* Connect a new interest to a person
* Add a link connected to a person and an interest

## Technologies

* C#
* ASP.NET Core Web API
* .NET Core 3.1
* Entity Framework Core
* SQL Server / SQL Server LocalDB
* LINQ
* Asynchronous programming
* JSON
* REST-style HTTP endpoints

> This is an older educational project built with .NET Core 3.1. Because that version is no longer supported, some adjustments may be required when running the project in a modern development environment.

## Project structure

* `Controllers` – defines the API endpoints and handles HTTP requests
* `Services` – contains the application logic and database operations
* `Models` – contains the database entities
* `Migrations` – contains the Entity Framework Core database migrations
* `appsettings.json` – contains the local database connection string
* `Startup.cs` – configures services, Entity Framework and request handling

## Getting started

### Requirements

To run the project, you need:

* .NET Core 3.1 SDK
* SQL Server or SQL Server Express LocalDB
* Entity Framework Core command-line tools

### 1. Clone the repository

```bash
git clone https://github.com/Chris8one/Labb3API.git
cd Labb3API/Labb3API
```

### 2. Restore the packages

```bash
dotnet restore
```

### 3. Configure the database

The default connection string uses SQL Server LocalDB:

```json
{
  "ConnectionStrings": {
    "Connection": "Server=(localdb)\\MSSQLLocalDB;Database=LabbThreeAPIDb;Trusted_Connection=True;"
  }
}
```

Update the connection string in `appsettings.json` if you use another SQL Server configuration.

### 4. Create the database

Apply the included Entity Framework migrations:

```bash
dotnet ef database update
```

### 5. Start the API

```bash
dotnet run
```

The terminal will display the local address used by the application, for example:

```text
Now listening on: https://localhost:5001
```

The port may be different on your computer. Use the address displayed in the terminal together with the endpoints below.

## API endpoints

### Get all people

```http
GET /api/helion/persons
```

### Get a person by ID

```http
GET /api/helion/persons/{id}
```

Example:

```http
GET /api/helion/persons/1
```

### Search for people by name

```http
GET /api/helion/persons/{name}
```

Example:

```http
GET /api/helion/persons/jason
```

### Get the interests connected to a person

```http
GET /api/helion/interests/{personId}
```

Example:

```http
GET /api/helion/interests/1
```

### Get the links connected to a person

```http
GET /api/helion/links/{personId}
```

Example:

```http
GET /api/helion/links/1
```

### Create a new person

```http
POST /api/helion/persons
```

Example request body:

```json
{
  "firstName": "Jason",
  "lastName": "Voorhees",
  "phone": "555-123-4567",
  "email": "jason.voorhees@friday13th.com"
}
```

### Connect a new interest to a person

```http
POST /api/helion/newinterest/{personId}
```

Example:

```http
POST /api/helion/newinterest/5
```

Example request body:

```json
{
  "interestTitle": "Problem Solving",
  "interestDescription": "Enjoys solving problems through programming."
}
```

### Add a link connected to a person and an interest

```http
POST /api/helion/newlink/personid/{personId}/interestid/{interestId}
```

Example:

```http
POST /api/helion/newlink/personid/5/interestid/9
```

Example request body:

```json
{
  "linkDescription": "A video about solving programming problems",
  "linkUrl": "https://www.youtube.com/watch?v=Dblfmk3ATeg"
}
```

## Background

This was my third school project in the Entity Framework course. The assignment focused on creating an API that models relationships between people, interests and links.

The project gave me practical experience with ASP.NET Core Web API, Entity Framework Core, relational data, dependency injection, asynchronous methods and HTTP requests.
