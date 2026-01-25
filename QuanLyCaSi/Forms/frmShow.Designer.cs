namespace QuanLyCaSi.Forms
{
    partial class frmShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(57, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 252);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Show";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(684, 220);
            dataGridView1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(424, 55);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 86);
            textBox2.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 55);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 35;
            label2.Text = "Bài hát";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(175, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(159, 27);
            dateTimePicker1.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 89);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 32;
            label4.Text = "Ngày diễn ra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 62);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 31;
            label1.Text = "Tên Show";
            // 
            // button7
            // 
            button7.Location = new Point(29, 19);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 30;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(589, 147);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 29;
            button6.Text = "Thoát";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(473, 147);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 28;
            button5.Text = "Huỷ";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(363, 147);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 27;
            button4.Text = "Lưu";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(263, 147);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 26;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(163, 147);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 25;
            button2.Text = "Xoá";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(63, 147);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 24;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmShow";
            Text = "frmShow";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}