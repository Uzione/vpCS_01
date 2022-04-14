namespace _131
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("이름을 입력하세요", "Warning");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("이름을 입력하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else label2.Text = textBox1.Text + "님! 안녕하세요!";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}