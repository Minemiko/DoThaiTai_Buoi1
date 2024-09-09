namespace DoThaiTai_Buoi1
{
    partial class TT
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
            txtNS = new TextBox();
            txtDS = new TextBox();
            txtT = new TextBox();
            txtTL = new TextBox();
            txtTC = new TextBox();
            label6 = new Label();
            btnN = new Button();
            btnTT = new Button();
            btnT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 33);
            label1.TabIndex = 0;
            label1.Text = "Nhập dãy số và tính tổng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 1;
            label3.Text = "Dãy vừa nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 145);
            label4.Name = "label4";
            label4.Size = new Size(282, 25);
            label4.TabIndex = 1;
            label4.Text = "Tổng các phần tử trong dãy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 184);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 1;
            label5.Text = "Tổng chẵn:";
            // 
            // txtNS
            // 
            txtNS.Location = new Point(167, 64);
            txtNS.Name = "txtNS";
            txtNS.Size = new Size(100, 33);
            txtNS.TabIndex = 2;
            // 
            // txtDS
            // 
            txtDS.Location = new Point(167, 103);
            txtDS.Name = "txtDS";
            txtDS.ReadOnly = true;
            txtDS.Size = new Size(233, 33);
            txtDS.TabIndex = 2;
            // 
            // txtT
            // 
            txtT.Location = new Point(300, 142);
            txtT.Name = "txtT";
            txtT.ReadOnly = true;
            txtT.Size = new Size(100, 33);
            txtT.TabIndex = 2;
            // 
            // txtTL
            // 
            txtTL.Location = new Point(336, 181);
            txtTL.Name = "txtTL";
            txtTL.ReadOnly = true;
            txtTL.Size = new Size(64, 33);
            txtTL.TabIndex = 2;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(136, 181);
            txtTC.Name = "txtTC";
            txtTC.ReadOnly = true;
            txtTC.Size = new Size(64, 33);
            txtTC.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 184);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 1;
            label6.Text = "Tổng lẻ:";
            // 
            // btnN
            // 
            btnN.Location = new Point(300, 63);
            btnN.Name = "btnN";
            btnN.Size = new Size(100, 33);
            btnN.TabIndex = 3;
            btnN.Text = "Nhập";
            btnN.UseVisualStyleBackColor = true;
            btnN.Click += btnN_Click;
            // 
            // btnTT
            // 
            btnTT.Location = new Point(82, 225);
            btnTT.Name = "btnTT";
            btnTT.Size = new Size(100, 33);
            btnTT.TabIndex = 3;
            btnTT.Text = "Tiếp tục";
            btnTT.UseVisualStyleBackColor = true;
            btnTT.Click += btnTT_Click;
            // 
            // btnT
            // 
            btnT.Location = new Point(241, 225);
            btnT.Name = "btnT";
            btnT.Size = new Size(100, 33);
            btnT.TabIndex = 3;
            btnT.Text = "Thoát";
            btnT.UseVisualStyleBackColor = true;
            btnT.Click += btnT_Click;
            // 
            // TT
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 279);
            Controls.Add(btnT);
            Controls.Add(btnTT);
            Controls.Add(btnN);
            Controls.Add(txtTC);
            Controls.Add(txtTL);
            Controls.Add(txtT);
            Controls.Add(txtDS);
            Controls.Add(txtNS);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "TT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NHẬP DÃY SỐ VÀ TÍNH TỔNG";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNS;
        private TextBox txtDS;
        private TextBox txtT;
        private TextBox txtTL;
        private TextBox txtTC;
        private Label label6;
        private Button btnN;
        private Button btnTT;
        private Button btnT;
    }
}