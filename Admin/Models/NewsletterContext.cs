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
        private readonly List<Newsletter> _newsletters = new();

        public List<Newsletter> Newsletters => _newsletters;

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

                command.Parameters.AddWithValue("news_title", newsletter.Title);

                if (newsletter.Description != null)
                    command.Parameters.AddWithValue("news_description", newsletter.Description);
                else
                    command.Parameters.AddWithValue("news_description", DBNull.Value);

                command.Parameters.AddWithValue("news_link", newsletter.Link);
                
                conn.Open();

                command.Prepare();
                int rowsAffected = command.ExecuteNonQuery();
                command.Parameters.Clear();

                conn.Close();

                isSuccess = rowsAffected > 0;

                if (isSuccess)
                {
                    _newsletters.Add(newsletter);
                }
            }

            return isSuccess;
        }
    }
}
