namespace winformmethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcom", "Obesity testling program");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //"ปุ่มคำนวณ  BMI"
            //input  รับค่า textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double weight = Convert.ToDouble(txtWeight.Text);

            //Process คำนวณค่า BMI
            double bmi = weight / Math.Pow(height / 100, 2);
            //Output เเปลงผล โดยนำค่า BMI มาเทียบค่ามาตรฐาน
            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;  //จัดชิดขวา
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            txtName.Focus();
           
            
        }
    }
}
