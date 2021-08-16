
namespace HalykBankWFP
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
            this.box_name = new System.Windows.Forms.TextBox();
            this.box_age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_test = new System.Windows.Forms.TextBox();
            this.btn_end = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box_name
            // 
            this.box_name.Location = new System.Drawing.Point(42, 93);
            this.box_name.Multiline = true;
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(241, 23);
            this.box_name.TabIndex = 0;
            // 
            // box_age
            // 
            this.box_age.Location = new System.Drawing.Point(42, 166);
            this.box_age.Multiline = true;
            this.box_age.Name = "box_age";
            this.box_age.Size = new System.Drawing.Size(241, 23);
            this.box_age.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ваше имя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваш возраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Решите задачу: 2+2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // box_test
            // 
            this.box_test.Location = new System.Drawing.Point(42, 247);
            this.box_test.Multiline = true;
            this.box_test.Name = "box_test";
            this.box_test.Size = new System.Drawing.Size(241, 23);
            this.box_test.TabIndex = 5;
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(42, 294);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(132, 23);
            this.btn_end.TabIndex = 6;
            this.btn_end.Text = "Завершить";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(429, 93);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 15);
            this.lbl_result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.box_test);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_age);
            this.Controls.Add(this.box_name);
            this.Name = "Form1";
            this.Text = "IQ тест";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.TextBox box_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_test;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Label lbl_result;
    }
}

