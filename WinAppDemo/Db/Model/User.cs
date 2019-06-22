using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDemo.Db.Model
{
    [Table("t_atd_data")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("station_id")]
        public string station_id { get; set; }

        [Column("device_id")]
        public string device_id { get; set; }

        [Column("position")]
        public string position { get; set; }

        [Column("status")]
        public int status { get; set; }

        [Column("last_time")]
        public string last_time { get; set; }
    }
}
