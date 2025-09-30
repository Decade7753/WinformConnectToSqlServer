using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormConnectToSqlServer_Project.EFCore
{
    [Table("UserTForWinform")]
    public class ModelForEF
    {
        [Key]
        public string username { get; set; }    
        public string password { get; set; }
        public string nickname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
