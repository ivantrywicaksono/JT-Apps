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
                string sql = "INSERT INTO newsletters()";
                conn.Open();
            }

            return isSuccess;
        }
    }
}
