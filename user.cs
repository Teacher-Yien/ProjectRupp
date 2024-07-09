using EnvDTE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shcool_management
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
			tbUser.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS", 14, FontStyle.Bold);
		}

        private void user_Load(object sender, EventArgs e)
        {

        }

	}
}
