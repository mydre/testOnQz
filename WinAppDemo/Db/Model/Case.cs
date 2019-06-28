using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinAppDemo.Db.Model
{
    [Table("CaseInfor")]
    public class Case
    {
        [Key]
        public int CaseId { get; set; } = 0;

        public string Path { get; set; }

        public string CaseName { get; set; }

        public string CaseSerialNum { get; set; }

        public string CaseType { get; set; }

        public string Collecter { get; set; }

        public string CollecterNum { get; set; }

        public string CollecterDepartMent { get; set; }

        public string InspectionPersonName { get; set; }

        public string InspectionPersonNum { get; set; }

        public string InspectionPersonDepartMent { get; set; }

        public string Note { get; set; }

        public string ObjectName { get; set; }

        public string ObjectPapersType { get; set; }

        public string ObjectPapersCode { get; set; }

        public string NetSecurityDepartMent { get; set; }

        public string ManufacturerName { get; set; }

        public string ManufacturerCode { get; set; }

        public string DataCollectType { get; set; }

        public string DataSourceNum { get; set; }

        public string OrganizationCode { get; set; }

        public string CreateCaseTime { get; set; }

        public List<Proof> Proofs { get; set; } = new List<Proof>();
    }
}
