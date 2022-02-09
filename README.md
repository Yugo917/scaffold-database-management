# scaffold-database-management

## Purpose
- The purpose of this scaffold it's to give a sample of automated data base versionning management in a CICD workflow.
- This versionning management is powered by [Flyway](https://flywaydb.org/), [Docker](https://www.docker.com/) and [Cake](https://cakebuild.net/)

## Behavior of Flyway
- Executing migrate is idempotent and can be done safely regardless of the current version of the schema.
- Example 1: We have migrations available up to version 9, and the database is at version 5.
Migrate will apply the migrations 6, 7, 8 and 9 in order.
- Example 2: We have migrations available up to version 9, and the database is at version 9.
Migrate does nothing.
- Example 3: We have migrations available up to version 9, and the database is at version 5, but the version 8 is corrupted.
Migrate will apply the migrations 6, 7, in order and don't apply the 8, 9.

## Requirements
- Install [Docker](https://www.docker.com/) (to setup your dev env and apply your db update on a CICD workflow)
- Install [.NET](https://dotnet.microsoft.com/en-us/) (to be able to run crossplatform command)
- Execute `dotnet tool restore`

## Get Started
- Execute `dotnet cake` to see the help
- Execute `dotnet cake setup-dev-environment` to setup your dev environment

## Play With It
- Create some new sql files in the book_shop project, the files must have the [flyway convention naming](https://flywaydb.org/documentation/concepts/migrations#naming).
- And start to play with flyway with adding some sql files and recreate your dev environment with `dotnet cake setup-dev-environment`

### Sql folder strucutre (see: src/sql/book_shop)
- dataset : it is used for test or demo data scripts
- grants : it is used for grants scripts in your db
- schema : it is used for you db schema
```
book_shop/
├── dataset/
│   └── V999.0.0__sample_data.sql
├── grants/
│   └── V0.2.0__grants.sql
└── schema/
    ├── V1.0.0__Initial.sql
    └── V1.0.1__add_description_column.sql
```
