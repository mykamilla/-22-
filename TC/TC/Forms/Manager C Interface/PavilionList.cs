using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC
{
    public partial class PavilionList : Form
    {
        TCADO db = new TCADO();
        public PavilionList()
        {
            InitializeComponent();
        }

        private void PavilionList_Load(object sender, EventArgs e)
        {
            павильонBindingSource.DataSource = db.Павильон.ToList();
        }
    }
}
