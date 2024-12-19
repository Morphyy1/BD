using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DesignForBD
{
    public partial class Продукты : Form
    {
        private DataGridViewColumn COL;

        public Продукты()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.training_base_AT04_LavrinovichDataSet);

        }

        private void Продукты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "training_base_AT04_LavrinovichDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.training_base_AT04_LavrinovichDataSet.Product);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COL = new DataGridViewColumn();

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
            }

            if (radioButton1.Checked)
                productDataGridView.Sort(COL, ListSortDirection.Ascending);
            else 
                productDataGridView.Sort(COL, ListSortDirection.Descending);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource.Filter = "PNAME='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productBindingSource.Filter = String.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < productDataGridView.ColumnCount - 1; i++)
            {
                for (var j = 0; j < productDataGridView.RowCount - 1; j++)
                {
                    productDataGridView[i, j].Style.BackColor = Color.White;
                    productDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (var i = 0; i < productDataGridView.ColumnCount - 1; i++)
            {
                for (var j = 0; j < productDataGridView.RowCount - 1; j++)
                {
                    if (productDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        productDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        productDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                   
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
