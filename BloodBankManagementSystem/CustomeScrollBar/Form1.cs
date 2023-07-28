using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class Form1 : Form
    {

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams handlesParam = base.CreateParams;
        //        handlesParam.ExStyle |= 0x02000000;
        //        return handlesParam;
        //    }
        //}


        //int i = 0;

        public object CustomScrollBarHandle { get; private set; }

        public Form1()
        {
            InitializeComponent();
            //new TouchScroll(flowLayoutPanel1);

            //vScrollBar1.Value = panel1.VerticalScroll.Value;
            ////hScrollBar1.Value = this.HorizontalScroll.Value;

            //vScrollBar1.Maximum = panel1.VerticalScroll.Maximum;
            //vScrollBar1.Minimum = panel1.VerticalScroll.Minimum;
            //vScrollBar1.Scroll += VScrollBar1_Scroll;

            //hScrollBar1.Maximum = this.HorizontalScroll.Maximum;
            //hScrollBar1.Minimum = this.HorizontalScroll.Minimum;
            //label16.Text = this.VerticalScroll.Value.ToString();

        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //panel1.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //i++;
            //this.Controls.Add(new Button { Text = "Button" + i.ToString(),Location=new Point(10 , i * 30) } );
        }

        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {
            //vScrollBar1.Maximum = this.VerticalScroll.Maximum;
            //hScrollBar1.Maximum = this.HorizontalScroll.Maximum;
            //vScrollBar1.Height = this.Height;
        }

        private void Form1_ControlRemoved(object sender, ControlEventArgs e)
        {
            //vScrollBar1.Minimum = this.VerticalScroll.Minimum;
            //hScrollBar1.Minimum = this.HorizontalScroll.Minimum;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //this.VerticalScroll.Value = vScrollBar1.Value;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           //this.HorizontalScroll.Value = hScrollBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle handleRect = new Rectangle(0,0,16,16);
            CustomScrollBarHandle handle = new CustomScrollBarHandle(handleRect);

           
        }
    }
}
