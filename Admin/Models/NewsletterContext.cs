using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Admin.Models
{
    internal partial class NewsletterContext
    {
        public bool Insert(Newsletter newsletter)
        {
            bool isSuccess = false;

            using (NpgsqlConnection conn = new(connectionString))
            {

                string sql = "INSERT INTO newsletters " +
                    "(news_title, news_description, news_link) " +
                    "VALUES (@news_title, @news_description, @news_link)";

                NpgsqlCommand command = new()
                {
                    Connection = conn,
                    CommandText = sql
                };

                command.Parameters.AddWithValue("news_title", "VS Postgres");
                command.Parameters.AddWithValue("news_description", "Lorem ipsum asdf dolor sit amet, consectetur adipiscing elit.");
                command.Parameters.AddWithValue("news_link", "https://example.co/aksdQdSFadfD12ht");
                
                conn.Open();

                command.Prepare();
                int rowsAffected = command.ExecuteNonQuery();
                command.Parameters.Clear();

                conn.Close();

                isSuccess = rowsAffected > 0;
            }

            return isSuccess;
        }
    }
}
