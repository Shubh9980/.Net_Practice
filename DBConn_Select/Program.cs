/*
    Establishing Connectioon with database(dac36) and inserting data into table(product1)   

*/

using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

int i=0;
while(i<=42)
{
    Console.OutputEncoding=Encoding.Unicode;
    Console.Write("❤ ");
    i++;
}
Console.WriteLine();

Console.WriteLine("❤ Program to establish connection with database (dac36) and reading table (product1)❤");
i=0;
while(i<=42)
{
    Console.Write("❤ ");
    i++;
}
Console.WriteLine("\n");

MySqlConnection conn=new MySqlConnection();
conn.ConnectionString="server=192.168.10.150;user=dac36;password=welcome;database=dac36";
string query="insert into product1 values(2,'Clinic Plus Shampoo',' Hair cleansing shampoo.')";
MySqlCommand command=new MySqlCommand(query,conn);
try{
    conn.Open();
    if(conn.State==ConnectionState.Open)
    {
        Console.WriteLine("Connection established successfully.");
    }
    command.ExecuteNonQuery();

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    conn.Close();
}