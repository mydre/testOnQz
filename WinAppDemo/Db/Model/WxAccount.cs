using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDemo.Db.Model
{
    [Table("WXAccount")]
    public class WxAccount
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("wxID")]
        public string WxId { get; set; }

        [Column("accountID")]
        public string AccountId { get; set; }

        [Column("phoneNumber")]
        public string Phone { get; set; }

        [Column("sign")]
        public string Sign { get; set; }

        [Column("nickname")]
        public string NickName { get; set; }

        [Column("district")]
        public string District { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("QQid")]
        public string QQId { get; set; }

        [Column("avatarPath")]
        public string AvatarPath { get; set; }
    }
}
