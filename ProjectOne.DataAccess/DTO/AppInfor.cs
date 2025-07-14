using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne.DataAccess.DTO
{
    public class AppInfor
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Version { get; set; }
        public required bool IsDelete { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? Created_Date { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
