namespace DoThaiTai_Buoi1
{
    partial class DSTC
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
            txtS = new TextBox();
            txtC = new TextBox();
            btnTH = new Button();
            btnT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 33);
            label1.TabIndex = 0;
            label1.Text = "Đọc số thành chữ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập n ( từ 1 đến 9 ) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 1;
            label3.Text = "Kết quả:";
            // 
            // txtS
            // 
            txtS.Location = new Point(247, 80);
            txtS.Name = "txtS";
            txtS.Size = new Size(100, 33);
            txtS.TabIndex = 2;
            // 
            // txtC
            // 
            txtC.Location = new Point(109, 119);
            txtC.Name = "txtC";
            txtC.ReadOnly = true;
            txtC.Size = new Size(238, 33);
            txtC.TabIndex = 2;
            // 
            // btnTH
            // 
            btnTH.Location = new Point(46, 167);
            btnTH.Name = "btnTH";
            btnTH.Size = new Size(120, 33);
            btnTH.TabIndex = 3;
            btnTH.Text = "Thực hiện";
            btnTH.UseVisualStyleBackColor = true;
            btnTH.Click += btnTH_Click;
            // 
            // btnT
            // 
            btnT.Location = new Point(193, 167);
            btnT.Name = "btnT";
            btnT.Size = new Size(120, 33);
            btnT.TabIndex = 3;
            btnT.Text = "Thoát";
            btnT.UseVisualStyleBackColor = true;
            btnT.Click += btnT_Click;
            // 
            // DSTC
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 228);
            Controls.Add(btnT);
            Controls.Add(btnTH);
            Controls.Add(txtC);
            Controls.Add(txtS);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "DSTC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DSTC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtS;
        private TextBox txtC;
        private Button btnTH;
        private Button btnT;
    }
}