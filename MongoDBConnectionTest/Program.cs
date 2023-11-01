using MongoDB.Driver;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string connection_string = Environment.GetEnvironmentVariable("SlackDeals", EnvironmentVariableTarget.User);

TestConnection(connection_string);

static void TestConnection(string connectionString)
{
    MongoClient client = new(connectionString);
    var dbs = client.ListDatabaseNames().ToList();
    foreach (var db in dbs)
        Console.WriteLine(db);
}

void InsertSampleData()
{

}