using System;
using System.Data;
using Microsoft.Data.SqlClient;
string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=master;TrustServerCertificate=true";
using var connection = new SqlConnection(connectionString);
try
{
    connection.Open();
    using var command = new SqlCommand("SELECT @value + 10", connection);
    command.Parameters.Add("@value", SqlDbType.Int).Value = 32;
    Console.WriteLine("Database result: " + command.ExecuteScalar());
}
catch (SqlException ex)
{
    Console.WriteLine("SQL Server is unavailable: " + ex.Message);
}

