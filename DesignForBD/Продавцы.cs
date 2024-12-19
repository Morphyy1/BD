using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignForBD
{
    public partial class Продавцы : Form
    {
        public Продавцы()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void salespeopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salespeopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.training_base_AT04_LavrinovichDataSet);

        }

        private void cITYLabel_Click(object sender, EventArgs e)
        {

        }

        private void cITYTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
