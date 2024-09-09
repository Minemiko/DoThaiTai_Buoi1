namespace DoThaiTai_Buoi1
{
    partial class GPTB2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            label6 = new Label();
            txtKQ2 = new TextBox();
            label7 = new Label();
            btnG = new Button();
            btnX = new Button();
            btnT = new Button();
            txtKQ = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(351, 39);
            label1.TabIndex = 0;
            label1.Text = "Giải phương trình bậc 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập số a, b, c";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 1;
            label3.Text = "a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 118);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 25);
            label4.TabIndex = 1;
            label4.Text = "b:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 157);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 25);
            label5.TabIndex = 1;
            label5.Text = "c:";
            // 
            // txtA
            // 
            txtA.Location = new Point(101, 76);
            txtA.Name = "txtA";
            txtA.Size = new Size(243, 33);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(101, 115);
            txtB.Name = "txtB";
            txtB.Size = new Size(243, 33);
            txtB.TabIndex = 2;
            // 
            // txtC
            // 
            txtC.Location = new Point(101, 154);
            txtC.Name = "txtC";
            txtC.Size = new Size(243, 33);
            txtC.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(193, 190);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 1;
            label6.Text = "Kết quả";
            // 
            // txtKQ2
            // 
            txtKQ2.Location = new Point(66, 257);
            txtKQ2.Name = "txtKQ2";
            txtKQ2.ReadOnly = true;
            txtKQ2.Size = new Size(350, 33);
            txtKQ2.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 293);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 25);
            label7.TabIndex = 1;
            label7.Text = "Chọn thao tác";
            // 
            // btnG
            // 
            btnG.Location = new Point(66, 338);
            btnG.Name = "btnG";
            btnG.Size = new Size(100, 35);
            btnG.TabIndex = 3;
            btnG.Text = "Giải";
            btnG.UseVisualStyleBackColor = true;
            btnG.Click += btnG_Click;
            // 
            // btnX
            // 
            btnX.Location = new Point(182, 338);
            btnX.Name = "btnX";
            btnX.Size = new Size(120, 35);
            btnX.TabIndex = 3;
            btnX.Text = "Xóa trắng";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // btnT
            // 
            btnT.Location = new Point(317, 338);
            btnT.Name = "btnT";
            btnT.Size = new Size(100, 35);
            btnT.TabIndex = 3;
            btnT.Text = "Thoát";
            btnT.UseVisualStyleBackColor = true;
            btnT.Click += btnT_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(65, 218);
            txtKQ.Name = "txtKQ";
            txtKQ.ReadOnly = true;
            txtKQ.Size = new Size(350, 33);
            txtKQ.TabIndex = 2;
            // 
            // GPTB2
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 399);
            Controls.Add(btnT);
            Controls.Add(btnX);
            Controls.Add(btnG);
            Controls.Add(txtKQ);
            Controls.Add(txtKQ2);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "GPTB2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GPTB2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label6;
        private TextBox txtKQ2;
        private Label label7;
        private Button btnG;
        private Button btnX;
        private Button btnT;
        private TextBox txtKQ;
    }
}