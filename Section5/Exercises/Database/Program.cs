using System.Security.AccessControl;

var sqlConnection = new SqlConnection("abc123");
var oracleConnection = new OracleConnection("cde456");

sqlConnection.OpenConnection();
sqlConnection.CloseConnection();
Console.WriteLine(sqlConnection.ConnectionString);

oracleConnection.OpenConnection();
oracleConnection.CloseConnection();
Console.WriteLine(oracleConnection.ConnectionString);

var sqlDb = new DbCommand(sqlConnection, "SQL instruction...");
var oracleDb = new DbCommand(oracleConnection, "Oracle instruction...");

sqlDb.Execute();
oracleDb.Execute();