Context.Environment.WorkingDirectory = MakeAbsolute(Directory("cicd/cake/"));
var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var version = Argument("productversion", "1.0.0");

#load "cicd/cake/master.cake"

Setup(ctx =>
{
    Information($"Cake is running ...");
});

RunTarget(target);
