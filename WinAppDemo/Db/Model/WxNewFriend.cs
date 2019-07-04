using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinAppDemo.Db.Model
{
    [Table("WXNewFriend")]
    public class WxNewFriend
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("wxID")]
        public string WxId { get; set; }

        [Column("nickname")]
        public string NickName { get; set; }

        [Column("sex")]
        public int? Sex { get; set; }

        [Column("sign")]
        public string Sign { get; set; }

        [Column("remark")]
        public string Remark { get; set; }

        [Column("district")]
        public string District { get; set; }

        [Column("avatarPath")]
        public string AvatarPath { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("contentVerify")]
        public string ContentVerify { get; set; }

        [Column("lastModifiedTime")]
        public string LastModifiedTime { get; set; }        
    }
}
