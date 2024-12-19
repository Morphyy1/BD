using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Schema;

namespace DesignForBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var sales = new Продавцы();
            sales.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var customers = new Покупатели();
            customers.ShowDialog();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            var product = new Продукты();
            product.ShowDialog();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var itogi = new ITOGI();
            itogi.ShowDialog();
        }
    }
}
