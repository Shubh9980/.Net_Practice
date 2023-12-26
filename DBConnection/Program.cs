/*
    Establishing Connectioon with database(dac36) and reading the content of a table(product1)   

*/

/*
    Steps: 

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


MySqlConnection connect =new MySqlConnection();
connect.ConnectionString="server=192.168.10.150;Port=3306;user=dac36;password=welcome;database=dac36";
string query="select *from product1";
MySqlCommand command=new MySqlCommand(query,connect);
try
{
    connect.Open();
    if(connect.State == ConnectionState.Open)
    Console.WriteLine("Connection established successfully.");
    Console.WriteLine();
    MySqlDataReader read =command.ExecuteReader();
    if(read.Read()!=null)
        {
            Console.WriteLine("Table is empty.");
        }
    while(read.Read())
    {
        int id=int.Parse(read["id"].ToString());
        string title=read["title"].ToString();
        string description=read["description"].ToString();
        Console.WriteLine(id+" "+title+" "+description);
    }
        read.Close();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    connect.Close();
}

