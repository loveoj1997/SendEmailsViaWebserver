using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emailform
{
    public partial class emailform : Form
    {
        public emailform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.SendTo.Text.Length <= 0)
            {
                this.SendTo.Focus();
                return;
            }
            if (this.SendSubject.Text.Length <= 0)
            {
                this.SendSubject.Focus();
                return;
            }

            localhost.WebService1 mEmailManager = new localhost.WebService1();

            try
            {
                this.send.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                string mResult = mEmailManager.Send("TeRiRi", this.SendTo.Text, this.SendSubject.Text, this.SendBox.Text);

                if (mResult != Boolean.TrueString)
                {
                    if (mResult == Boolean.FalseString)
                    {
                        MessageBox.Show("Failed to Send");
                        return;
                    }
                    MessageBox.Show(mResult);
                    return;
                }
                MessageBox.Show("Successfully send");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            finally
            {
                this.send.Enabled = true;
                this.Cursor = Cursors.Default;
            }
            
        }
    }
}
