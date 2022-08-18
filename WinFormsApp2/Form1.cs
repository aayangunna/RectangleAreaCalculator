using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleAreaCalculator
{
    /// <summary>
    ///  An app that calculate the Area of a Rectangle
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        /// <summary>
        ///  Clears inputed values and output
        /// </summary>
        {
            tbLength.Text = "";
                tbWidth.Text = "";
                tbArea.Text = "";
        }


        private void tbArea_TextChanged(object sender, EventArgs e)
        {

        }
    private void btnCalculate_Click(object sender, EventArgs e)

        /// <summary>
        ///  Calculates the Area of a rectangle
        /// </summary>
        {
            try
                {
                    var length = double.Parse(tbLength.Text);
                    var width = double.Parse(tbWidth.Text);
                    var area = AreaCalculator(length, width);
                    tbArea.Text = area.ToString();
                }
                catch (Exception exception)
                {
                    tbArea.Text = "Something went wrong";
                }
            }

            public double AreaCalculator(double length, double width)
            {
                var area = length * width;
                return area;
            }
        
    }
}
