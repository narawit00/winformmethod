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
            //"�����ӹǳ  BMI"
            //input  �Ѻ��� textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double weight = Convert.ToDouble(txtWeight.Text);

            //Process �ӹǳ��� BMI
            double bmi = weight / Math.Pow(height / 100, 2);
            //Output ��ŧ�� �¹Ӥ�� BMI ����º����ҵðҹ
            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;  //�Ѵ�Դ���
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
