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
    }

}
