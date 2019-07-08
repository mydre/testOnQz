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
        public int caseId_selected_row;
        public int caseId_selected_working;
        public bool already_working;


        //public int selected_UcAjgl_Aj_rowIndex;

        private AppConfig()
        {
            this.working_directory = "";
            this.caseId_selected_row = -1;
            this.caseId_selected_working = -1;
            this.already_working = false;
        }

        public static AppConfig getAppConfig()
        {
            if (appConfig == null) appConfig = new AppConfig();
            return appConfig;
        }

        public static void AppConfigAddAdvinceClear()
        {
            appConfig.already_working = false;
            appConfig.caseId_selected_working = -1;
        }
    }
}
