using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinAppDemo.Db.Model
{
    [Table("ProofInfor")]
    public class Proof
    {
        [Key]
        public int ProofId { get; set; }

        public int CaseID { get; set; }

        public virtual Case Case { get; set; }

        public string ProofName { get; set; }

        public string ProofSerialNum { get; set; }

        public string PhoneNum { get; set; }

        public string Holder { get; set; }

        public string CredentialsSerialNum { get; set; }

        public string CredentialsType { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string DeviceType { get; set; }

        public string ProofType { get; set; }

        public string note { get; set; }

        public string PhonePwdFlag { get; set; }

        public string PhonePwd { get; set; }

        public string phoneNum2 { get; set; }

        public string otherpath { get; set; }

        public string CreateProofTime { get; set; }

        public string IMEI { get; set; }

        public string IMEI2 { get; set; }

        public string phoneType { get; set; }

        public string phoneBrand { get; set; }

        public string phoneDataCount { get; set; }

        public string noteMsgDataCount { get; set; }

        public string addressBookCount { get; set; }

        public string qqDataCount { get; set; }

        public string callRecordsCount { get; set; }

        public string momoDataCount { get; set; }

        public string wxDataCount { get; set; }

        public string proofStatisticStatus { get; set; }
    }
}
