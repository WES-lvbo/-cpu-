namespace WindowsFormsCPU
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.R0_text = new System.Windows.Forms.TextBox();
            this.SR_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PC_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.R2_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.R3_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.R4_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.R5_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.R6_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.R1_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.R7_text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Do = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.OPcode_text = new System.Windows.Forms.TextBox();
            this.File_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.File_do = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Input.Location = new System.Drawing.Point(629, 51);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(185, 30);
            this.Input.TabIndex = 0;
            // 
            // R0_text
            // 
            this.R0_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R0_text.Location = new System.Drawing.Point(45, 57);
            this.R0_text.Name = "R0_text";
            this.R0_text.Size = new System.Drawing.Size(103, 30);
            this.R0_text.TabIndex = 1;
            // 
            // SR_text
            // 
            this.SR_text.Location = new System.Drawing.Point(251, 52);
            this.SR_text.Name = "SR_text";
            this.SR_text.Size = new System.Drawing.Size(202, 25);
            this.SR_text.TabIndex = 2;
            this.SR_text.TextChanged += new System.EventHandler(this.SR_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "sr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "PC";
            // 
            // PC_text
            // 
            this.PC_text.Location = new System.Drawing.Point(251, 115);
            this.PC_text.Name = "PC_text";
            this.PC_text.Size = new System.Drawing.Size(100, 25);
            this.PC_text.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "R0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "R3";
            // 
            // R2_text
            // 
            this.R2_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R2_text.Location = new System.Drawing.Point(45, 161);
            this.R2_text.Name = "R2_text";
            this.R2_text.Size = new System.Drawing.Size(103, 30);
            this.R2_text.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "R4";
            // 
            // R3_text
            // 
            this.R3_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R3_text.Location = new System.Drawing.Point(45, 213);
            this.R3_text.Name = "R3_text";
            this.R3_text.Size = new System.Drawing.Size(103, 30);
            this.R3_text.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "R2";
            // 
            // R4_text
            // 
            this.R4_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R4_text.Location = new System.Drawing.Point(45, 265);
            this.R4_text.Name = "R4_text";
            this.R4_text.Size = new System.Drawing.Size(103, 30);
            this.R4_text.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "R5";
            // 
            // R5_text
            // 
            this.R5_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R5_text.Location = new System.Drawing.Point(45, 317);
            this.R5_text.Name = "R5_text";
            this.R5_text.Size = new System.Drawing.Size(103, 30);
            this.R5_text.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(12, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "R6";
            // 
            // R6_text
            // 
            this.R6_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R6_text.Location = new System.Drawing.Point(45, 369);
            this.R6_text.Name = "R6_text";
            this.R6_text.Size = new System.Drawing.Size(103, 30);
            this.R6_text.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(12, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "R1";
            // 
            // R1_text
            // 
            this.R1_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R1_text.Location = new System.Drawing.Point(45, 109);
            this.R1_text.Name = "R1_text";
            this.R1_text.Size = new System.Drawing.Size(103, 30);
            this.R1_text.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(12, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "R7";
            // 
            // R7_text
            // 
            this.R7_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.R7_text.Location = new System.Drawing.Point(45, 421);
            this.R7_text.Name = "R7_text";
            this.R7_text.Size = new System.Drawing.Size(103, 30);
            this.R7_text.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(548, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "input";
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(629, 106);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(75, 23);
            this.Do.TabIndex = 22;
            this.Do.Text = "执行";
            this.Do.UseVisualStyleBackColor = true;
            this.Do.Click += new System.EventHandler(this.Do_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "机器码";
            // 
            // OPcode_text
            // 
            this.OPcode_text.Enabled = false;
            this.OPcode_text.Location = new System.Drawing.Point(258, 204);
            this.OPcode_text.Multiline = true;
            this.OPcode_text.Name = "OPcode_text";
            this.OPcode_text.Size = new System.Drawing.Size(270, 25);
            this.OPcode_text.TabIndex = 24;
            this.OPcode_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // File_button
            // 
            this.File_button.Location = new System.Drawing.Point(629, 214);
            this.File_button.Name = "File_button";
            this.File_button.Size = new System.Drawing.Size(75, 34);
            this.File_button.TabIndex = 25;
            this.File_button.Text = "文件";
            this.File_button.UseVisualStyleBackColor = true;
            this.File_button.Click += new System.EventHandler(this.File_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(742, 204);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(377, 255);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // File_do
            // 
            this.File_do.Location = new System.Drawing.Point(629, 270);
            this.File_do.Name = "File_do";
            this.File_do.Size = new System.Drawing.Size(75, 31);
            this.File_do.TabIndex = 27;
            this.File_do.Text = "逐行执行";
            this.File_do.UseVisualStyleBackColor = true;
            this.File_do.Click += new System.EventHandler(this.File_do_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 850);
            this.Controls.Add(this.File_do);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.File_button);
            this.Controls.Add(this.OPcode_text);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.R7_text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.R1_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.R6_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.R5_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.R4_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.R3_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.R2_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PC_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SR_text);
            this.Controls.Add(this.R0_text);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox R0_text;
        private System.Windows.Forms.TextBox SR_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PC_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox R2_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox R3_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox R4_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox R5_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox R6_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox R1_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox R7_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Do;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox OPcode_text;
        private System.Windows.Forms.Button File_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button File_do;
    }
}

