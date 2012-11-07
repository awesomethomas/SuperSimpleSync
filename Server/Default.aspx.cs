using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Server
{
    public partial class _Default : System.Web.UI.Page
    {
        private AccountManager actMgr = AccountManager.Instance;
        protected void Page_Load(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = actMgr.GetStorageDir();
            DirectoryInfo[] fileInfo = dirInfo.GetDirectories("*.*", SearchOption.TopDirectoryOnly);
            AccountList.DataSource = fileInfo;
            AccountList.DataBind();
            if (!IsPostBack)
            {
                GetFilesAndFolders();
            }

        }
        public void GetFilesAndFolders()
        {
            DirectoryInfo dirInfo = actMgr.GetStorageDir();
            FileInfo[] fileInfo = dirInfo.GetFiles("*.*", SearchOption.AllDirectories);
            GridView1.DataSource = fileInfo;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }

}
