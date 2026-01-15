using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class debugForm : Form
    {
        public debugForm()
        {
            InitializeComponent();
        }

        public void PopulateLog(List<string> logs) {
            logListBox.Items.AddRange(logs.ToArray());
        }
    }
}
