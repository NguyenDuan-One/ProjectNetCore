using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.DataAccess.DTO
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        public required string name { get; set; }
        public bool is_delete { get; set; }
        public  string? create_user { get; set; }
        public DateTime? create_date { get; set; }
        //public AppInfor? app_infor { get; set; }
    }

    public class CategoryRequestData
    {
        public string? Name { get; set; }
    }

    public class CategoryInsertData
    {
        public required string name { get; set; }
        public bool is_delete { get; set; }
    }
}
