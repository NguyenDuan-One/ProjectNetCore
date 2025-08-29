using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.DataAccess.DTO
{
    public class AppInfor
    {
        [Key]
        public long id { get; set; }
        public string? name { get; set; }
        public string? link { get; set; }
        public string? status { get; set; }
        public string? version { get; set; }
        public  bool is_delete { get; set; }
        public string? create_user { get; set; }
        public DateTime? create_date { get; set; }
        public string? update_user { get; set; }
        public DateTime? update_date { get; set; }
    }
}
