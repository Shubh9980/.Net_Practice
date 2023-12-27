using MySql.Data.MySqlClient;
using System.Data;
using System.Text;


Console.WriteLine("\n\n");
int j=0;
while(j<=32)
{
    Console.OutputEncoding=Encoding.Unicode;
    Console.Write("💗 ");
    j++;
}
Console.WriteLine();
Console.WriteLine("💗 Program to establish connection with database(dac36) and delete item from the table(product1)💗");
j=0;
while(j<=32)
{
    Console.Write("💗 ");
    j++;
}
Console.WriteLine("\n");

MySqlConnection connection=new MySqlConnection();
connection.ConnectionString="server=192.168.10.150;port=3306;user=dac36;password=welcome;database=dac36";

string query="delete from product1 where id=@id1";

try 
{
    Console.WriteLine("Enter the number of items you want to delete :");
    int num=int.Parse(Console.ReadLine());

    connection.Open();
    if(connection.State==ConnectionState.Open)
    Console.WriteLine("Connection established successfully");

    int i=0;
    int id2;
    while(i<num)
    {
        MySqlCommand command =new MySqlCommand(query,connection);
        Console.Write("Enter the id of the element you want to delete : ");
        id2=int.Parse(Console.ReadLine());

        command.Parameters.AddWithValue("@id1",id2);

        command.ExecuteNonQuery();
        Console.WriteLine("Deleted Successfully.");
        i++;
    }


}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    connection.Close();
}