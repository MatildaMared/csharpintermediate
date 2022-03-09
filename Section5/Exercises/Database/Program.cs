var sqlConnection = new SqlConnection("abc123");
var oracleConnection = new OracleConnection("cde456");

sqlConnection.OpenConnection();
sqlConnection.CloseConnection();
Console.WriteLine(sqlConnection.ConnectionString);

oracleConnection.OpenConnection();
oracleConnection.CloseConnection();
Console.WriteLine(oracleConnection.ConnectionString);