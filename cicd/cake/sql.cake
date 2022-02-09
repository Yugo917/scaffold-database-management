/// <summary>
/// Publish all sql projects
/// </summary>
/// <value></value>
Task("publish-sql").Does(() => 
{
    foreach(var sqlProject in sqlProjects)
    {
        var sqlProjectPath = System.IO.Path.Combine(sqlProjectsRootPath,sqlProject);
        SqlClean(publishDir,sqlProject);
        SqlPublish(sqlProject,sqlProjectsRootPath,publishDir);
    }
});

void SqlClean(string publishDir, string projectName)
{
   var publishDirectoryName =  projectName;
   var publishDirPrj= System.IO.Path.Combine(publishDir,publishDirectoryName);
   Information($"Cleaninig Directory {publishDirPrj} ...");
   CleanDirectory(publishDirPrj);
}

void SqlPublish(string projectName, string sqlProjectsRootPath, string publishDir)
{    
    var sqlProjectPublishDir = System.IO.Path.Combine(publishDir, projectName);
    CreateDirectory(sqlProjectPublishDir);
    Information($"Publishing sql/{projectName} in {sqlProjectPublishDir} ...");
    CopyDirectory(System.IO.Path.Combine(sqlProjectsRootPath,projectName),sqlProjectPublishDir);
}

void CreateAllSqlProjectPublishDir()
{
    foreach(var sqlProject in sqlProjects)
    {
        CreateDirectory(System.IO.Path.Combine(publishDir, sqlProject));
    }
}
