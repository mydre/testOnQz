using System.Data.Entity;
using WinAppDemo.Db.Model;

namespace WinAppDemo.Db.Base
{
    public class CaseContext : DbContext
    {
        public CaseContext() : base("caseConnection")
        {
        }

        public DbSet<Case> Cases { get; set; }

        public DbSet<Proof> Proofs { get; set; }
    }
}
