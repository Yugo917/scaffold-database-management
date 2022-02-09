Task("setup-environment") 
    .Does(() => 
{
    DockerComposeUp(new DockerComposeUpSettings
    {
        Files = new [] {System.IO.Path.Combine(dockerComposeRootPath,$"docker-compose.{env}.yml")},
        Build = true,
        ForceRecreate = true,
        DetachedMode = true,
        Verbose = false,
    });
});

Task("clean-environment")
.Does(() => 
{
    CreateAllSqlProjectPublishDir(); // To avoid initial error when publish dir has never been created yet
    
    DockerComposeDown(new DockerComposeDownSettings
    {
        Files = new [] {System.IO.Path.Combine(dockerComposeRootPath,$"docker-compose.{env}.yml")},
        RemoveOrphans = true,
        Volumes = true,
        Rmi = "local",
        Verbose = false,
    });    
});
