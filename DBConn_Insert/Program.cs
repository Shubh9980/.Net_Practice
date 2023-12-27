/*
    Establishing Connectioon with database(dac36) and inserting data into table(product1)   

*/

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

Console.WriteLine("💗 Program to establish connection with database(dac36) and inserting data into table (product1)💗");
j=0;
while(j<=32)
{
    Console.Write("💗 ");
    j++;
}
Console.WriteLine("\n");



MySqlConnection conn=new MySqlConnection();
conn.ConnectionString="server=192.168.10.150;port=3306;user=dac36;password=welcome;database=dac36";

string query="Insert into product1 values(@id,@title,@description)";
try
{   
    Console.WriteLine("Enter number of products you want to add :");
    int num=Convert.ToInt32(Console.ReadLine());
    int [] id1=new int[num];
    string [] title1=new string[num];
    string [] desc1=new string[num];
    conn.Open();
    if(conn.State==ConnectionState.Open)
    Console.WriteLine("Connection established successfully.");
    int i=0;
    while(i<num)
    {
        Console.WriteLine("Enter id of"+" product "+(i+1));
        id1[i]=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter title of"+" product "+(i+1));
        title1[i]=Console.ReadLine();
        Console.WriteLine("Enter description of"+" product "+(i+1));
        desc1[i]=Console.ReadLine();
        i++;
    }
    i=0;
    while(i<num)
    {
        
        MySqlCommand command=new MySqlCommand(query,conn);
        command.Parameters.AddWithValue("@id",id1[i]);
        command.Parameters.AddWithValue("@title",title1[i]);
        command.Parameters.AddWithValue("@description", desc1[i]);
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
    conn.Close();
    if(conn.State==ConnectionState.Closed)
    {
        Console.WriteLine("Connection closed successfully.");
    }
}