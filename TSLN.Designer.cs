﻿namespace DoThaiTai_Buoi1
{
    partial class TSLN
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
            txtKQ = new TextBox();
            btnTH = new Button();
            btnTT = new Button();
            btnT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 33);
            label1.TabIndex = 0;
            label1.Text = "Tìm số lớn nhất trong 3 số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập số A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 1;
            label3.Text = "Nhập số B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 1;
            label4.Text = "Nhập số C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 177);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 1;
            label5.Text = "Kết quả:";
            // 
            // txtA
            // 
            txtA.Location = new Point(133, 57);
            txtA.Name = "txtA";
            txtA.Size = new Size(74, 33);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(133, 96);
            txtB.Name = "txtB";
            txtB.Size = new Size(74, 33);
            txtB.TabIndex = 2;
            // 
            // txtC
            // 
            txtC.Location = new Point(133, 135);
            txtC.Name = "txtC";
            txtC.Size = new Size(74, 33);
            txtC.TabIndex = 2;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(133, 174);
            txtKQ.Name = "txtKQ";
            txtKQ.ReadOnly = true;
            txtKQ.Size = new Size(207, 33);
            txtKQ.TabIndex = 2;
            // 
            // btnTH
            // 
            btnTH.Location = new Point(213, 57);
            btnTH.Name = "btnTH";
            btnTH.Size = new Size(127, 33);
            btnTH.TabIndex = 3;
            btnTH.Text = "Thực hiện";
            btnTH.UseVisualStyleBackColor = true;
            btnTH.Click += btnTH_Click;
            // 
            // btnTT
            // 
            btnTT.Location = new Point(213, 95);
            btnTT.Name = "btnTT";
            btnTT.Size = new Size(127, 33);
            btnTT.TabIndex = 3;
            btnTT.Text = "Tiếp tục";
            btnTT.UseVisualStyleBackColor = true;
            btnTT.Click += btnTT_Click;
            // 
            // btnT
            // 
            btnT.Location = new Point(213, 134);
            btnT.Name = "btnT";
            btnT.Size = new Size(127, 33);
            btnT.TabIndex = 3;
            btnT.Text = "Thoát";
            btnT.UseVisualStyleBackColor = true;
            btnT.Click += btnT_Click;
            // 
            // TSLN
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 223);
            Controls.Add(btnT);
            Controls.Add(btnTT);
            Controls.Add(btnTH);
            Controls.Add(txtKQ);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "TSLN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TÌM SỐ LỚN NHẤT";
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
        private TextBox txtKQ;
        private Button btnTH;
        private Button btnTT;
        private Button btnT;
    }
}