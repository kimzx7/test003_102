namespace test003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //double a1 = Convert.ToDouble(txt_triangle2.Text);
            double a1 = 0;
            double a2 = 0;

            if (double.TryParse(txt_triangle1.Text, out a1) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                txt_triangle1.Focus();
                txt_triangle1.SelectAll();
                return;
            }
            //double a2 = Convert.ToDouble(txt_triangle1.Text);
            if(double.TryParse(txt_triangle2.Text, out a2) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                txt_triangle2.Focus();
                txt_triangle2.SelectAll();
                return;
            }
            double a3 = 0.5 * (a1 * a2);
            lblshow_triangle.Text = "��鹷������������ ���" + a3;

            txt_triangle2.Focus();
            txt_triangle2.SelectAll();
            */
            triangle_test();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            //double a1 = Convert.ToDouble(txt_circle.Text);
            double a1 = 0;
            if (double.TryParse(txt_circle.Text, out a1) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                txt_circle.Focus();
                txt_circle.SelectAll();
                return;
            }
            //double a2 = Convert.ToDouble(textBox2.Text);
            double a3 = Math.PI * Math.Pow(a1, 2);
            lblshow_circle.Text = "��鹷��ǧ��� ���" + a3;

            txt_circle.Focus();
            txt_circle.SelectAll();
            */

            circle_test();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            //double a1 = Convert.ToDouble(txt_hexagon.Text);
            double a1 = 0;
            if (double.TryParse(txt_hexagon.Text, out a1) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                txt_hexagon.Focus();
                txt_hexagon.SelectAll();
                return;
            }
            //double a2 = Convert.ToDouble(textBox2.Text);
            double a3 = (3 * Math.Sqrt(3) / 2) * Math.Pow(a1, 2);
            lblshow_hexagon.Text = "��鹷��ˡ������� ���" + a3;

            txt_hexagon.Focus();
            txt_hexagon.SelectAll();
            */

            double result = hexagon_test();  
 
                lblshow_hexagon.Text = "��鹷��ˡ������� ��� "+ result;
                txt_hexagon.Focus();
                txt_hexagon.SelectAll();
 

        }

        private void circle_test()
        {
            //double a1 = Convert.ToDouble(txt_circle.Text);
            double a1 = 0;
            if (double.TryParse(txt_circle.Text, out a1) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                txt_circle.Focus();
                txt_circle.SelectAll();
                return;
            }
            //double a2 = Convert.ToDouble(textBox2.Text);
            double a3 = Math.PI * Math.Pow(a1, 2);
            lblshow_circle.Text = "��鹷��ǧ��� ���" + a3;

            txt_circle.Focus();
            txt_circle.SelectAll();
        }

        private void triangle_test()
        {
            //double a1 = Convert.ToDouble(txt_triangle2.Text);
            double a1 = 0;
            double a2 = 0;

            if (double.TryParse(txt_triangle1.Text, out a1) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                txt_triangle1.Focus();
                txt_triangle1.SelectAll();
                return;
            }
            //double a2 = Convert.ToDouble(txt_triangle1.Text);
            if (double.TryParse(txt_triangle2.Text, out a2) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                txt_triangle2.Focus();
                txt_triangle2.SelectAll();
                return;
            }
            double a3 = 0.5 * (a1 * a2);
            lblshow_triangle.Text = "��鹷������������ ���" + a3;

            txt_triangle2.Focus();
            txt_triangle2.SelectAll();
        }

        private double hexagon_test()
        {
            double a1 = 0;
            if (double.TryParse(txt_hexagon.Text, out a1) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                txt_hexagon.Focus();
                txt_hexagon.SelectAll();
                //return null;
            }

            double a3 = (3 * Math.Sqrt(3) / 2) * Math.Pow(a1, 2);


            return  a3;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("�Թ�յ͹�Ѻ", "��ҡ�͡������", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("��ͧ��èлԴ�����", "�Դ�����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }













        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
