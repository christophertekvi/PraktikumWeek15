
namespace PraktikumWeek15
{
    partial class Form2
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
            this.checkBoxDiskon = new System.Windows.Forms.CheckBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.labelPersen = new System.Windows.Forms.Label();
            this.labelSub = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelHargaTotal = new System.Windows.Forms.Label();
            this.labelHrgTax = new System.Windows.Forms.Label();
            this.labelDisc = new System.Windows.Forms.Label();
            this.labelHrgTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxDiskon
            // 
            this.checkBoxDiskon.AutoSize = true;
            this.checkBoxDiskon.Location = new System.Drawing.Point(12, 12);
            this.checkBoxDiskon.Name = "checkBoxDiskon";
            this.checkBoxDiskon.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDiskon.TabIndex = 0;
            this.checkBoxDiskon.Text = "DISCOUNT";
            this.checkBoxDiskon.UseVisualStyleBackColor = true;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(30, 36);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(31, 13);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Input";
            // 
            // buttonHitung
            // 
            this.buttonHitung.Location = new System.Drawing.Point(12, 73);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(92, 35);
            this.buttonHitung.TabIndex = 2;
            this.buttonHitung.Text = "CALCULATE";
            this.buttonHitung.UseVisualStyleBackColor = true;
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.Location = new System.Drawing.Point(68, 36);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiskon.TabIndex = 3;
            // 
            // labelPersen
            // 
            this.labelPersen.AutoSize = true;
            this.labelPersen.Location = new System.Drawing.Point(174, 39);
            this.labelPersen.Name = "labelPersen";
            this.labelPersen.Size = new System.Drawing.Size(15, 13);
            this.labelPersen.TabIndex = 4;
            this.labelPersen.Text = "%";
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Location = new System.Drawing.Point(243, 13);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(46, 13);
            this.labelSub.TabIndex = 5;
            this.labelSub.Text = "Subtotal";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(243, 43);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(25, 13);
            this.labelTax.TabIndex = 6;
            this.labelTax.Text = "Tax";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(243, 73);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(49, 13);
            this.labelDiscount.TabIndex = 7;
            this.labelDiscount.Text = "Discount";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(243, 103);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total";
            // 
            // labelHargaTotal
            // 
            this.labelHargaTotal.AutoSize = true;
            this.labelHargaTotal.Location = new System.Drawing.Point(329, 16);
            this.labelHargaTotal.Name = "labelHargaTotal";
            this.labelHargaTotal.Size = new System.Drawing.Size(0, 13);
            this.labelHargaTotal.TabIndex = 9;
            // 
            // labelHrgTax
            // 
            this.labelHrgTax.AutoSize = true;
            this.labelHrgTax.Location = new System.Drawing.Point(329, 43);
            this.labelHrgTax.Name = "labelHrgTax";
            this.labelHrgTax.Size = new System.Drawing.Size(0, 13);
            this.labelHrgTax.TabIndex = 10;
            // 
            // labelDisc
            // 
            this.labelDisc.AutoSize = true;
            this.labelDisc.Location = new System.Drawing.Point(329, 73);
            this.labelDisc.Name = "labelDisc";
            this.labelDisc.Size = new System.Drawing.Size(0, 13);
            this.labelDisc.TabIndex = 11;
            // 
            // labelHrgTotal
            // 
            this.labelHrgTotal.AutoSize = true;
            this.labelHrgTotal.Location = new System.Drawing.Point(329, 103);
            this.labelHrgTotal.Name = "labelHrgTotal";
            this.labelHrgTotal.Size = new System.Drawing.Size(0, 13);
            this.labelHrgTotal.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 338);
            this.Controls.Add(this.labelHrgTotal);
            this.Controls.Add(this.labelDisc);
            this.Controls.Add(this.labelHrgTax);
            this.Controls.Add(this.labelHargaTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.labelPersen);
            this.Controls.Add(this.textBoxDiskon);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.checkBoxDiskon);
            this.Name = "Form2";
            this.Text = "CHECKOUT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDiskon;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonHitung;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.Label labelPersen;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelHargaTotal;
        private System.Windows.Forms.Label labelHrgTax;
        private System.Windows.Forms.Label labelDisc;
        private System.Windows.Forms.Label labelHrgTotal;
    }
}