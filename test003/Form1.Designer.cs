namespace test003
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_triangle = new Button();
            btn_circle = new Button();
            btn_hexagon = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_triangle2 = new TextBox();
            txt_triangle1 = new TextBox();
            lblshow_circle = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txt_circle = new TextBox();
            groupBox2 = new GroupBox();
            lblshow_triangle = new Label();
            groupBox3 = new GroupBox();
            lblshow_hexagon = new Label();
            label5 = new Label();
            txt_hexagon = new TextBox();
            btn_out = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_triangle
            // 
            btn_triangle.Location = new Point(355, 60);
            btn_triangle.Name = "btn_triangle";
            btn_triangle.Size = new Size(148, 49);
            btn_triangle.TabIndex = 0;
            btn_triangle.Text = "คำนวณหาพื้นที่สี่เหลี่ยม\r\n";
            btn_triangle.UseVisualStyleBackColor = true;
            btn_triangle.Click += button1_Click;
            // 
            // btn_circle
            // 
            btn_circle.Location = new Point(355, 53);
            btn_circle.Name = "btn_circle";
            btn_circle.Size = new Size(148, 49);
            btn_circle.TabIndex = 1;
            btn_circle.Text = "คำนวณหาพื้นที่วงกลม\r\n";
            btn_circle.UseVisualStyleBackColor = true;
            btn_circle.Click += button2_Click;
            // 
            // btn_hexagon
            // 
            btn_hexagon.Location = new Point(355, 67);
            btn_hexagon.Name = "btn_hexagon";
            btn_hexagon.Size = new Size(148, 49);
            btn_hexagon.TabIndex = 2;
            btn_hexagon.Text = "คำนวณหาพื้นที่หกเหลี่ยม";
            btn_hexagon.UseVisualStyleBackColor = true;
            btn_hexagon.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "ความสูง";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 98);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "ความยาวฐาน";
            // 
            // txt_triangle2
            // 
            txt_triangle2.Location = new Point(131, 98);
            txt_triangle2.Name = "txt_triangle2";
            txt_triangle2.Size = new Size(177, 27);
            txt_triangle2.TabIndex = 5;
            // 
            // txt_triangle1
            // 
            txt_triangle1.Location = new Point(133, 48);
            txt_triangle1.Name = "txt_triangle1";
            txt_triangle1.Size = new Size(175, 27);
            txt_triangle1.TabIndex = 6;
            // 
            // lblshow_circle
            // 
            lblshow_circle.BackColor = Color.WhiteSmoke;
            lblshow_circle.ForeColor = Color.Black;
            lblshow_circle.Location = new Point(546, 34);
            lblshow_circle.Name = "lblshow_circle";
            lblshow_circle.Size = new Size(209, 87);
            lblshow_circle.TabIndex = 15;
            lblshow_circle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_circle);
            groupBox1.Controls.Add(btn_circle);
            groupBox1.Controls.Add(lblshow_circle);
            groupBox1.Location = new Point(23, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 153);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "หาพื้นที่วงกลม";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 64);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 7;
            label4.Text = "รัศมี";
            // 
            // txt_circle
            // 
            txt_circle.Location = new Point(133, 64);
            txt_circle.Name = "txt_circle";
            txt_circle.Size = new Size(175, 27);
            txt_circle.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkGray;
            groupBox2.Controls.Add(lblshow_triangle);
            groupBox2.Controls.Add(txt_triangle2);
            groupBox2.Controls.Add(btn_triangle);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_triangle1);
            groupBox2.Location = new Point(23, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(802, 153);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "หาพื้นที่สามเหลี่ยม";
            // 
            // lblshow_triangle
            // 
            lblshow_triangle.BackColor = Color.WhiteSmoke;
            lblshow_triangle.ForeColor = Color.Black;
            lblshow_triangle.Location = new Point(546, 41);
            lblshow_triangle.Name = "lblshow_triangle";
            lblshow_triangle.Size = new Size(209, 87);
            lblshow_triangle.TabIndex = 16;
            lblshow_triangle.TextAlign = ContentAlignment.MiddleCenter;
            lblshow_triangle.Click += label3_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkGray;
            groupBox3.Controls.Add(lblshow_hexagon);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txt_hexagon);
            groupBox3.Controls.Add(btn_hexagon);
            groupBox3.Location = new Point(23, 380);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(802, 153);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "หาพื้นที่หกเหลี่ยม";
            // 
            // lblshow_hexagon
            // 
            lblshow_hexagon.BackColor = Color.WhiteSmoke;
            lblshow_hexagon.ForeColor = Color.Black;
            lblshow_hexagon.Location = new Point(546, 48);
            lblshow_hexagon.Name = "lblshow_hexagon";
            lblshow_hexagon.Size = new Size(209, 87);
            lblshow_hexagon.TabIndex = 17;
            lblshow_hexagon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 81);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 8;
            label5.Text = "ความยาวฐาน";
            // 
            // txt_hexagon
            // 
            txt_hexagon.Location = new Point(133, 78);
            txt_hexagon.Name = "txt_hexagon";
            txt_hexagon.Size = new Size(175, 27);
            txt_hexagon.TabIndex = 8;
            txt_hexagon.TextChanged += textBox4_TextChanged;
            // 
            // btn_out
            // 
            btn_out.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_out.Location = new Point(23, 560);
            btn_out.Name = "btn_out";
            btn_out.Size = new Size(802, 63);
            btn_out.TabIndex = 16;
            btn_out.Text = "กดเพื่อออก";
            btn_out.UseVisualStyleBackColor = true;
            btn_out.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 651);
            Controls.Add(btn_out);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "โปรแกรมคำนวณพืนที่";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_triangle;
        private Button btn_circle;
        private Button btn_hexagon;
        private Label label1;
        private Label label2;
        private TextBox txt_triangle2;
        private TextBox txt_triangle1;
        private Label lblshow_circle;
        private GroupBox groupBox1;
        private TextBox txt_circle;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txt_hexagon;
        private Label label4;
        private Label label5;
        private Button btn_out;
        private Label lblshow_triangle;
        private Label lblshow_hexagon;
    }
}
