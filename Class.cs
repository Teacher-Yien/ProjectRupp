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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
            // Set the font size for the header
            tbClass.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS", 12, FontStyle.Bold);
        }

        private void btn_Add_new_Class_Click(object sender, EventArgs e)
        {
            using (Add_new_Class cClass = new Add_new_Class()) {
            
              cClass.ShowDialog();
            }
        }

        private void btn_up_Calss_Click(object sender, EventArgs e)
        {
            using (update_new_class upClass = new update_new_class())
            {

                upClass.ShowDialog();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
