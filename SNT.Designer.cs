namespace DoThaiTai_Buoi1
{
    partial class SNT
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
            txtS = new TextBox();
            txtKT = new TextBox();
            txtSNT = new TextBox();
            btnT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 33);
            label1.TabIndex = 0;
            label1.Text = "Kiểm tra và số nguyên tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 72);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập n:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 111);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 1;
            label3.Text = "Kiểm tra SNT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 1;
            label4.Text = "Tìm SNT nhỏ hơn n:";
            // 
            // txtS
            // 
            txtS.Location = new Point(221, 69);
            txtS.Name = "txtS";
            txtS.Size = new Size(100, 33);
            txtS.TabIndex = 2;
            // 
            // txtKT
            // 
            txtKT.Location = new Point(221, 108);
            txtKT.Name = "txtKT";
            txtKT.Size = new Size(206, 33);
            txtKT.TabIndex = 2;
            // 
            // txtSNT
            // 
            txtSNT.Location = new Point(221, 147);
            txtSNT.Name = "txtSNT";
            txtSNT.Size = new Size(206, 33);
            txtSNT.TabIndex = 2;
            // 
            // btnT
            // 
            btnT.Location = new Point(327, 68);
            btnT.Name = "btnT";
            btnT.Size = new Size(100, 33);
            btnT.TabIndex = 3;
            btnT.Text = "Thoát";
            btnT.UseVisualStyleBackColor = true;
            btnT.Click += btnT_Click;
            // 
            // SNT
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 210);
            Controls.Add(btnT);
            Controls.Add(txtSNT);
            Controls.Add(txtKT);
            Controls.Add(txtS);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "SNT";
            Text = "SỐ NGUYÊN TỐ";
            Load += SNT_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtS;
        private TextBox txtKT;
        private TextBox txtSNT;
        private Button btnT;
    }
}