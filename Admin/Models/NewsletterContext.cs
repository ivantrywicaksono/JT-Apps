using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Admin.Models
{
    internal partial class NewsletterContext
    {
        private readonly List<Newsletter> _newsletters = new();

        public List<Newsletter> Newsletters => _newsletters;

        public bool Insert(Newsletter newsletter)
        {
            bool isSuccess = false;

            using (NpgsqlConnection connection = new(connectionString))
            {

                string sql = "INSERT INTO newsletters " +
                    "(news_title, news_description, news_link) " +
                    "VALUES (@news_title, @news_description, @news_link)";

                using (NpgsqlCommand command = new(sql, connection))
                {
                    command.Parameters.AddWithValue("news_title", newsletter.Title);

                    if (!string.IsNullOrWhiteSpace(newsletter.Description))
                        command.Parameters.AddWithValue("news_description", newsletter.Description);
                    else
                        command.Parameters.AddWithValue("news_description", DBNull.Value);

                    command.Parameters.AddWithValue("news_link", newsletter.Link);

                    connection.Open();

                    command.Prepare();
                    int rowsAffected = command.ExecuteNonQuery();
                    command.Parameters.Clear();

                    connection.Close();

                    isSuccess = rowsAffected > 0;
                }


                if (isSuccess)
                {
                    _newsletters.Add(newsletter);
                    MessageBox.Show("Successss");
                }
            }

            return isSuccess;
        }

        public bool ReadAll()
        {
            bool isSuccess = false;

            using (NpgsqlConnection connection = new(connectionString))
            {
                string sql = "SELECT * FROM newsletters";

                using NpgsqlCommand command = new(sql, connection);

                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();

                _newsletters.Clear();

                while (reader.Read())
                {
                    string description = ConvertFromDBVal<string>(reader["news_description"]);

                    Newsletter newsletter = new
                    (
                        (string)reader["news_title"],
                        description,
                        (string)reader["news_link"],
                        (int)reader["news_id"]
                    );

                    _newsletters.Add(newsletter);
                }

                connection.Close();
            }

            return isSuccess;
        }

        public Newsletter GetById(int id)
        {
            using NpgsqlConnection connection = new(connectionString);

            string sql = "SELECT * FROM newsletters WHERE news_id = @news_id";

            using NpgsqlCommand command = new(sql, connection);
            command.Parameters.Add("news_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id;

            connection.Open();

            command.Prepare();
            NpgsqlDataReader reader = command.ExecuteReader();
            command.Parameters.Clear();

            reader.Read();

            string description = ConvertFromDBVal<string>(reader["news_description"]);

            Newsletter newsletter = new
            (
                (string)reader["news_title"],
                description,
                (string)reader["news_link"],
                (int)reader["news_id"]
            );

            connection.Close();

            return newsletter;
        }

        public static T ConvertFromDBVal<T>(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return default(T); // returns the default value for the type
            }
            else
            {
                return (T)obj;
            }
        }
    }
}
