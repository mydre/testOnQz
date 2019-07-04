using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinAppDemo.Forms;

namespace WinAppDemo
{
    static class Program
    {
        public static MainForm m_mainform = null;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_mainform = new MainForm();
            Application.Run(m_mainform);



        }
    }
}
