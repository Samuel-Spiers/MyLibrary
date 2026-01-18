using System.Collections.Generic;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class debugForm : Form
    {
        List<string> StackTraceLog;

        public debugForm(List<string> stackTraceLog)
        {
            InitializeComponent();
            StackTraceLog = stackTraceLog;
        }

        public void PopulateLog(List<string> logs) {
            logListBox.Items.AddRange(logs.ToArray());
        }

        private void logListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            stackTraceTextBox.Clear();
            if (logListBox.SelectedIndex != -1 && StackTraceLog[logListBox.SelectedIndex] != null) {
                stackTraceTextBox.Text = StackTraceLog[logListBox.SelectedIndex];
            }
        }
    }
}
