namespace Calculator
{
    partial class Form1
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
            this.btCong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(356, 177);
            this.btCong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(66, 31);
            this.btCong.TabIndex = 0;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(130, 29);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(255, 29);
            this.txtA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(130, 75);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(255, 29);
            this.txtB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả:";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(130, 123);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(255, 29);
            this.txtKetqua.TabIndex = 2;
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.Location = new System.Drawing.Point(242, 177);
            this.btTru.Margin = new System.Windows.Forms.Padding(6);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(66, 31);
            this.btTru.TabIndex = 0;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 251);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btTru;
    }
}

