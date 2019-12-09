using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixPicutre
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }


        int index = 1;
        bool ok = true;

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;
            tableLayoutPicture1.Order = (TableLayoutPicture.PictureTable.IndexOrder)Enum.Parse(typeof(TableLayoutPicture.PictureTable.IndexOrder), (string)comboBox1.SelectedItem);
            ok = true;
            tableLayoutPicture1.ClearImage();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index <= tableLayoutPicture1.RowCount * tableLayoutPicture1.ColumnCount)
                tableLayoutPicture1.ShowImage(index++, ok);
            else
            { index = 1; ok = !ok; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            
            comboBox1.Items.AddRange(Enum.GetNames(typeof(TableLayoutPicture.PictureTable.IndexOrder)));
        }
    }
}
