using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SailboatDestinationWinForms
{
    public partial class SailboatDestination : MetroFramework.Forms.MetroForm
    {
        public SailboatDestination()
        {
            InitializeComponent();
        }

        private void SailboatDestination_Load(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            
            Selection selected = new Selection(Int32.Parse(crewSizeTextBox.Text), difficultyComboBox.Text, typeComboBox.Text, budgetComboBox.Text);
            
            MessageBox.Show("Generating results for:" + selected.MsgBoxMsg());

        }

        private void difficultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
