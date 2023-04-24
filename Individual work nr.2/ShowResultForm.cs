using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_work_nr._2
{
    public partial class ShowResultForm : Form
    {
        internal string results;
        public ShowResultForm(string results)
        {
            InitializeComponent();
            this.results = results;
        }

        private void ShowResultForm_Load(object sender, EventArgs e)
        {
            display_result_label.Text = results;
        }
    }
}
