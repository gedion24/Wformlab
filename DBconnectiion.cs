using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WformLab
{
    public partial class DBconnectiion : Form
    {
        public DBconnectiion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBservice dbservice = new DBservice();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBservice DBS = new DBservice();
            
        }
    }
}
