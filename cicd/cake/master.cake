// ----- Help
Task("help")
.Does(()=>
{
    Console.WriteLine(@"HELP");
});

// ----- Composed task
Task("default")
.IsDependentOn("help");
