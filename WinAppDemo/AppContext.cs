using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDemo.Controls;

namespace WinAppDemo
{
    public class AppContext
    {
        private static AppContext appContext = new AppContext();

        public UcZjtq_SJ m_ucZjtq_sj;
        public UcZjtq_JX m_ucZjtq_jx;
        public UcZjtq_SJ_Ljcg m_ucZjtq_sj_ljcg;
        public UcZjtq_SJ_QZ1 m_ucZjtq_sj_qz1;
        public UcZjtq_SJ_QZ2 m_ucZjtq_sj_qz2;
        public UcZjtq_SJ_QZ3 m_ucZjtq_sj_qz3;

        private AppContext()
        {
            m_ucZjtq_sj = new UcZjtq_SJ();

            m_ucZjtq_jx = new UcZjtq_JX();
            m_ucZjtq_sj_ljcg = new UcZjtq_SJ_Ljcg();
            m_ucZjtq_sj_qz1 = new UcZjtq_SJ_QZ1();
            m_ucZjtq_sj_qz2 = new UcZjtq_SJ_QZ2();
            m_ucZjtq_sj_qz3 = new UcZjtq_SJ_QZ3();
        }

        public static AppContext GetInstance()
        {
            if (appContext == null)
            {
                appContext = new AppContext();
            }

            return appContext;
        }

        public static int CaseID = 0;
    }
}
