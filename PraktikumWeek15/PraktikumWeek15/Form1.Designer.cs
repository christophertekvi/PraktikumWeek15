
namespace PraktikumWeek15
{
    partial class FormPesen
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
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelitems = new System.Windows.Forms.Label();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelAngkaHarga = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMinum = new System.Windows.Forms.RadioButton();
            this.radioButtonMakan = new System.Windows.Forms.RadioButton();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radioButtonJumbo = new System.Windows.Forms.RadioButton();
            this.radioButtonSzNorm = new System.Windows.Forms.RadioButton();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(233, 9);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(272, 42);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Depot Bu Budi";
            // 
            // labelitems
            // 
            this.labelitems.AutoSize = true;
            this.labelitems.Location = new System.Drawing.Point(121, 57);
            this.labelitems.Name = "labelitems";
            this.labelitems.Size = new System.Drawing.Size(40, 13);
            this.labelitems.TabIndex = 1;
            this.labelitems.Text = "ITEMS";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(12, 73);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(175, 251);
            this.listBoxMenu.TabIndex = 2;
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.Location = new System.Drawing.Point(193, 73);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(110, 251);
            this.listBoxHarga.TabIndex = 3;
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(403, 126);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMenu.TabIndex = 4;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(365, 129);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(34, 13);
            this.labelMenu.TabIndex = 5;
            this.labelMenu.Text = "Menu";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(530, 129);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(36, 13);
            this.labelHarga.TabIndex = 6;
            this.labelHarga.Text = "Harga";
            // 
            // labelAngkaHarga
            // 
            this.labelAngkaHarga.AutoSize = true;
            this.labelAngkaHarga.Location = new System.Drawing.Point(573, 129);
            this.labelAngkaHarga.Name = "labelAngkaHarga";
            this.labelAngkaHarga.Size = new System.Drawing.Size(0, 13);
            this.labelAngkaHarga.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMinum);
            this.groupBox1.Controls.Add(this.radioButtonMakan);
            this.groupBox1.Location = new System.Drawing.Point(368, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 42);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonMinum
            // 
            this.radioButtonMinum.AutoSize = true;
            this.radioButtonMinum.Location = new System.Drawing.Point(97, 15);
            this.radioButtonMinum.Name = "radioButtonMinum";
            this.radioButtonMinum.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMinum.TabIndex = 1;
            this.radioButtonMinum.TabStop = true;
            this.radioButtonMinum.Text = "Minuman";
            this.radioButtonMinum.UseVisualStyleBackColor = true;
            this.radioButtonMinum.CheckedChanged += new System.EventHandler(this.radioButtonMinum_CheckedChanged);
            // 
            // radioButtonMakan
            // 
            this.radioButtonMakan.AutoSize = true;
            this.radioButtonMakan.Location = new System.Drawing.Point(6, 15);
            this.radioButtonMakan.Name = "radioButtonMakan";
            this.radioButtonMakan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMakan.TabIndex = 0;
            this.radioButtonMakan.TabStop = true;
            this.radioButtonMakan.Text = "Makanan";
            this.radioButtonMakan.UseVisualStyleBackColor = true;
            this.radioButtonMakan.CheckedChanged += new System.EventHandler(this.radioButtonMakan_CheckedChanged);
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.radioButtonJumbo);
            this.groupBoxSize.Controls.Add(this.radioButtonSzNorm);
            this.groupBoxSize.Location = new System.Drawing.Point(368, 182);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(191, 41);
            this.groupBoxSize.TabIndex = 9;
            this.groupBoxSize.TabStop = false;
            // 
            // radioButtonJumbo
            // 
            this.radioButtonJumbo.AutoSize = true;
            this.radioButtonJumbo.Location = new System.Drawing.Point(99, 14);
            this.radioButtonJumbo.Name = "radioButtonJumbo";
            this.radioButtonJumbo.Size = new System.Drawing.Size(56, 17);
            this.radioButtonJumbo.TabIndex = 1;
            this.radioButtonJumbo.TabStop = true;
            this.radioButtonJumbo.Text = "Jumbo";
            this.radioButtonJumbo.UseVisualStyleBackColor = true;
            this.radioButtonJumbo.Visible = false;
            // 
            // radioButtonSzNorm
            // 
            this.radioButtonSzNorm.AutoSize = true;
            this.radioButtonSzNorm.Location = new System.Drawing.Point(7, 14);
            this.radioButtonSzNorm.Name = "radioButtonSzNorm";
            this.radioButtonSzNorm.Size = new System.Drawing.Size(58, 17);
            this.radioButtonSzNorm.TabIndex = 0;
            this.radioButtonSzNorm.TabStop = true;
            this.radioButtonSzNorm.Text = "Normal";
            this.radioButtonSzNorm.UseVisualStyleBackColor = true;
            this.radioButtonSzNorm.Visible = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(365, 166);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 13);
            this.labelSize.TabIndex = 10;
            this.labelSize.Text = "Size";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(427, 229);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(132, 38);
            this.buttonBuy.TabIndex = 11;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(124, 331);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(614, 340);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(132, 55);
            this.buttonCheckOut.TabIndex = 13;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // FormPesen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 407);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAngkaHarga);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.listBoxHarga);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.labelitems);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormPesen";
            this.Text = "Pesen Menu";
            this.Load += new System.EventHandler(this.FormPesen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelitems;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelAngkaHarga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMinum;
        private System.Windows.Forms.RadioButton radioButtonMakan;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton radioButtonJumbo;
        private System.Windows.Forms.RadioButton radioButtonSzNorm;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCheckOut;
    }
}

