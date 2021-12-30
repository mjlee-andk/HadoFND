using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadoFND
{
    class DataFormat
    {
        public class Product
        {
            public string id { get; set; }
            public string name { get; set; }
            public int unit_weight { get; set; }
            public int code_number { get; set; }
            public DateTime created_at { get; set; }
            public DateTime? deleted_at { get; set; }
        }

        public class User
        {
            public string id { get; set; }
            public string account { get; set; }
            public string name { get; set; }
            public DateTime created_at { get; set; }
            public DateTime? deleted_at { get; set; }
        }

        public class WorkRecord
        {
            public string id { get; set; }
            public User user { get; set; }
            public Product product { get; set; }
            public int weight { get; set; }
            public int total_weight { get; set; }
            public int work_count { get; set; }
            public Boolean is_finish { get; set; }
            public DateTime created_at { get; set; }
        }
    }
}
