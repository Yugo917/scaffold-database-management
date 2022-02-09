// Arguments
var env = Argument<string>("env","dev");

// Shared
var publishDir = "../../publish/";

// DockerCompose
var dockerComposeRootPath = "../docker-compose";

// SQL
var sqlProjectsRootPath = "../../src/";
var sqlProjects = new []
{
	"book_shop.sql",
};
