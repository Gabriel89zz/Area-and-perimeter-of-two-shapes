using Microsoft.VisualBasic;

namespace Area_and_perimeter_of_two_shapes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateRect_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle rectangle1 = new Rectangle();
                rectangle1.Height = Convert.ToDouble(txtbHeightRect.Text);
                rectangle1.Base = Convert.ToDouble(txtbBaseRect.Text);
                txtbAreaRect.Text = rectangle1.GetArea().ToString();
                txtbPerimeterRect.Text = rectangle1.GetPerimeter().ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("You must enter a numerical value","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnCalculateTrian_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle triangle1 = new Triangle();
                triangle1.Height = Convert.ToDouble(txtbHeightTrian.Text);
                triangle1.Base = Convert.ToDouble(txtbBaseTrian.Text);
                txtbAreaTrian.Text = triangle1.GetArea().ToString();
                txtbPerimeterTrian.Text = triangle1.GetPerimeter().ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("You must enter a numerical value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbHeightRect.Text = "";
            txtbBaseRect.Text = "";
            txtbAreaRect.Text = "";
            txtbPerimeterRect.Text = "";
            txtbHeightTrian.Text = "";
            txtbBaseTrian.Text = "";
            txtbAreaTrian.Text = "";
            txtbPerimeterTrian.Text = "";
        }
    }
}
