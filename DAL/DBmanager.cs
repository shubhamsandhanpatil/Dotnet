using BOL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DAL;
public class DBmanager
{
    public static string constring = @"server=localhost;port=3306;user=root;password=root123;database=dotnet";
    public static List<Employee> getEmployees()
    {
        List<Employee> list = new List<Employee>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = constring;
        try
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string query = "select * from emp";
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                int age = int.Parse(reader["age"].ToString());
                Department department = Enum.Parse<Department>(reader["department"].ToString());
                DateOnly date = DateOnly.FromDateTime(DateTime.Parse(reader["date"].ToString()));
                Employee emp = new Employee(id, name, age, department, date);
                list.Add(emp);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally { conn.Close(); }
        return list;

    }
    public static void Delete(int id)
    {
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = constring;
        try
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection= conn;   
            string query = "delete from emp where id="+id;
            cmd.CommandText = query;
           cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally { conn.Close(); }
    }
}
