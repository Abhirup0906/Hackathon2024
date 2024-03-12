using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechRecognition.BL.Db.Entities
{
    [Table("User")]
    public class User
    {
        [Column("UserId")]
        public string UserId { get; set; } = string.Empty;

        [Column("UserName")]
        public string UserName { get; set; } = string.Empty;

        [Column("ProfileId")]
        public string ProfileId { get; set; } = string.Empty;   
    }
}
