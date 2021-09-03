
namespace TipCalculator
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
            this.labelbill = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.labeltip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minusTipButton = new System.Windows.Forms.Button();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.addTipButton = new System.Windows.Forms.Button();
            this.addPeopleButton = new System.Windows.Forms.Button();
            this.txtPersons = new System.Windows.Forms.TextBox();
            this.minusPeopleButton = new System.Windows.Forms.Button();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.line = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelbill
            // 
            this.labelbill.AutoSize = true;
            this.labelbill.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelbill.Location = new System.Drawing.Point(38, 86);
            this.labelbill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbill.Name = "labelbill";
            this.labelbill.Size = new System.Drawing.Size(47, 28);
            this.labelbill.TabIndex = 0;
            this.labelbill.Text = "Bill";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(42, 123);
            this.txtBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(352, 48);
            this.txtBill.TabIndex = 4;
            this.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBill.TextChanged += new System.EventHandler(this.txtBill_TextChanged);
            this.txtBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBill_KeyPress);
            // 
            // labeltip
            // 
            this.labeltip.AutoSize = true;
            this.labeltip.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labeltip.Location = new System.Drawing.Point(38, 209);
            this.labeltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltip.Name = "labeltip";
            this.labeltip.Size = new System.Drawing.Size(73, 28);
            this.labeltip.TabIndex = 2;
            this.labeltip.Text = "Tip %";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(38, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(520, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "per person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(519, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "per person";
            // 
            // minusTipButton
            // 
            this.minusTipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusTipButton.Location = new System.Drawing.Point(46, 247);
            this.minusTipButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minusTipButton.Name = "minusTipButton";
            this.minusTipButton.Size = new System.Drawing.Size(57, 50);
            this.minusTipButton.TabIndex = 7;
            this.minusTipButton.Text = "-";
            this.minusTipButton.UseVisualStyleBackColor = true;
            this.minusTipButton.Click += new System.EventHandler(this.minusTipButton_Click);
            // 
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTip.Location = new System.Drawing.Point(111, 247);
            this.txtTip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(217, 46);
            this.txtTip.TabIndex = 12;
            this.txtTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTip.TextChanged += new System.EventHandler(this.txtTip_TextChanged);
            this.txtTip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTip_KeyPress);
            // 
            // addTipButton
            // 
            this.addTipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTipButton.Location = new System.Drawing.Point(336, 247);
            this.addTipButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTipButton.Name = "addTipButton";
            this.addTipButton.Size = new System.Drawing.Size(57, 54);
            this.addTipButton.TabIndex = 8;
            this.addTipButton.Text = "+";
            this.addTipButton.UseVisualStyleBackColor = true;
            this.addTipButton.Click += new System.EventHandler(this.addTipButton_Click);
            // 
            // addPeopleButton
            // 
            this.addPeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPeopleButton.Location = new System.Drawing.Point(336, 370);
            this.addPeopleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPeopleButton.Name = "addPeopleButton";
            this.addPeopleButton.Size = new System.Drawing.Size(57, 53);
            this.addPeopleButton.TabIndex = 17;
            this.addPeopleButton.Text = "+";
            this.addPeopleButton.UseVisualStyleBackColor = true;
            this.addPeopleButton.Click += new System.EventHandler(this.addPeopleButton_Click);
            // 
            // txtPersons
            // 
            this.txtPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersons.Location = new System.Drawing.Point(111, 370);
            this.txtPersons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPersons.Name = "txtPersons";
            this.txtPersons.Size = new System.Drawing.Size(217, 46);
            this.txtPersons.TabIndex = 16;
            this.txtPersons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPersons.TextChanged += new System.EventHandler(this.txtPersons_TextChanged_1);
            this.txtPersons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersons_KeyPress);
            // 
            // minusPeopleButton
            // 
            this.minusPeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusPeopleButton.Location = new System.Drawing.Point(48, 370);
            this.minusPeopleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minusPeopleButton.Name = "minusPeopleButton";
            this.minusPeopleButton.Size = new System.Drawing.Size(57, 53);
            this.minusPeopleButton.TabIndex = 15;
            this.minusPeopleButton.Text = "-";
            this.minusPeopleButton.UseVisualStyleBackColor = true;
            this.minusPeopleButton.Click += new System.EventHandler(this.minusPeopleButton_Click);
            // 
            // txtResult1
            // 
            this.txtResult1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult1.Location = new System.Drawing.Point(663, 158);
            this.txtResult1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.ReadOnly = true;
            this.txtResult1.Size = new System.Drawing.Size(318, 46);
            this.txtResult1.TabIndex = 16;
            this.txtResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResult2
            // 
            this.txtResult2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult2.Location = new System.Drawing.Point(662, 295);
            this.txtResult2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.ReadOnly = true;
            this.txtResult2.Size = new System.Drawing.Size(318, 55);
            this.txtResult2.TabIndex = 17;
            this.txtResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Gainsboro;
            this.line.Location = new System.Drawing.Point(482, 0);
            this.line.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(3, 477);
            this.line.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 596);
            this.Controls.Add(this.line);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtResult1);
            this.Controls.Add(this.addPeopleButton);
            this.Controls.Add(this.txtPersons);
            this.Controls.Add(this.minusPeopleButton);
            this.Controls.Add(this.addTipButton);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.minusTipButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltip);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.labelbill);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelbill;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label labeltip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button minusTipButton;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button addTipButton;
        private System.Windows.Forms.Button addPeopleButton;
        private System.Windows.Forms.TextBox txtPersons;
        private System.Windows.Forms.Button minusPeopleButton;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.Label line;
    }
}

