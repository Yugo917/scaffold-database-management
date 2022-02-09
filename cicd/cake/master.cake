// ----- Help
Task("help")
.Does(()=>
{
    Console.WriteLine(@"
setup-dev-environment:      info: set up the development environment from scratch (with a docker-compose down & docker-compose up)
                            usage:  dotnet cake --target=setup-dev-environment
    ");
});

// ----- Composed task
Task("default")
.IsDependentOn("help");

Task("setup-dev-environment")
.IsDependentOn("publish-sql")
.IsDependentOn("clean-environment")
.IsDependentOn("setup-environment");
