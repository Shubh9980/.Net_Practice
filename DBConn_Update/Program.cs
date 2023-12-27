using MySql.Data.MySqlClient;
using System.Data;
using System.Text;


Console.WriteLine("\n\n");
int j=0;
while(j<=31)
{
    Console.OutputEncoding=Encoding.Unicode;
    Console.Write("💗 ");
    j++;
}
Console.WriteLine();
Console.WriteLine("💗 Program to establish connection with database (dac36) and update data in table (product1) 💗");
j=0;
while(j<=31)
{
    Console.Write("💗 ");
    j++;
}
Console.WriteLine("\n");

MySqlConnection connection=new MySqlConnection();
connection.ConnectionString="server=192.168.10.150;port=3306;user=dac36;password=welcome;database=dac36";

try
{
    string query="update product1 set description=@desc1,title=@title1 where id=@id1" ;
    
    Console.WriteLine("Enter the number of items you want to update :");
    int num=int.Parse(Console.ReadLine());
   
    connection.Open();
    if(connection.State==ConnectionState.Open)
    Console.WriteLine("Connection established successfully.");

    int id2;
    string desc2;
    string title2;
    
    int i=0;
    while(i<num)
    {
        Console.WriteLine("Enter the id of product you want to update :");
        id2=int.Parse(Console.ReadLine());
        
        Console.Write("Title :");
        title2=Console.ReadLine();
        Console.Write("Description :");
        desc2=Console.ReadLine();
        
        
        MySqlCommand command=new MySqlCommand(query,connection);
        command.Parameters.AddWithValue("@id1",id2);
        command.Parameters.AddWithValue("@title1",title2);
        command.Parameters.AddWithValue("@desc1",desc2);
        
        command.ExecuteNonQuery();
        
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
    if(connection.State==ConnectionState.Closed)
    Console.WriteLine("Connection closed successfully.");
}