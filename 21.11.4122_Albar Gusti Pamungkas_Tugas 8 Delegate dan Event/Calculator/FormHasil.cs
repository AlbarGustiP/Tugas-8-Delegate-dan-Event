using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormHasil : Form
    {
        private IList<ClassOperasi> listOfCalculator = new List<ClassOperasi>();
        public FormHasil()
        {
            InitializeComponent();
        }
        private void FormHasil_OnCreate(ClassOperasi cal)
        {
            listOfCalculator.Add(cal);
            listBox1.Items.Add(cal.Hasil);
        }
        private void bttnHitung_Click(object sender, EventArgs e)
        {
            FormCalculator formHasil = new FormCalculator("Calculator");
            formHasil.OnCreate += FormHasil_OnCreate;
            formHasil.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
