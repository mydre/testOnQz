using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinAppDemo.Db.Model
{
    [Table("WXAddressBook")]
    public class WxFriend
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

        [Column("avatarPath")]
        public string AvatarPath { get; set; }

        [Column("type")]
        public int Type { get; set; }

        [Column("sex")]
        public int? Sex { get; set; }

        [Column("remark")]
        public string Remark { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("chatFrom")]
        public string ChatFrom { get; set; }

        public override string ToString()
            => this.NickName;
    }
}
