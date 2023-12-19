using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace assignment_app
{
    internal class DatabaseConnection
    {
        private string connectionString;
        public DatabaseConnection()
        {
            this.connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=userdb;";
        }
        public MySqlConnection getConnection()
        {
            MySqlConnection connection = new MySqlConnection(this.connectionString);
            connection.Open();
            return connection;
        }

        public bool RegisterUser(string firstName, string lastName, string email, string password,string imagelocation)
        {
            bool success = false;
            MySqlConnection connection = getConnection();

            try
            {
                string query = "INSERT INTO users (firstName, lastName, email, password,imagelocation) VALUES (@firstName, @lastName, @email, @password,@imagelocation)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@imagelocation", imagelocation);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return success;
        }

        public bool SearchUserByEmail(string email, string password)
        {
            MySqlConnection connection = getConnection();

            try
            {
                string query = "SELECT * FROM users WHERE email = @email";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);

                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    if(reader.GetString("email") == email && reader.GetString("passsword") == password)
                    {
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        public String[] LoginUser(string email, string password)
        {
            MySqlConnection connection = getConnection();
            string[] users = new String[6];

            try
            {
                string query = "SELECT * FROM users WHERE email = @email AND password = @password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    users[0] = reader.GetString("id");
                    users[1] = reader.GetString("firstName");
                    users[2] = reader.GetString("lastName");
                    users[3] = reader.GetString("email");
                    users[4] = reader.GetString("password");
                    users[5] = reader.GetString("imagelocation");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return users;
            
        }
    }
}