using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDemo
{
    class AppConfig
    {

        private static AppConfig appConfig = new AppConfig();

        public string working_directory;
        public int selected_caseId;

        public int selected_UcAjgl_Aj_rowIndex;

        private AppConfig()
        {
            this.working_directory = "";
            this.selected_caseId = -1;
            this.selected_UcAjgl_Aj_rowIndex = -1;
        }

        public static AppConfig getAppConfig()
        {
            if (appConfig == null) appConfig = new AppConfig();
            return appConfig;
        }
    }
}
