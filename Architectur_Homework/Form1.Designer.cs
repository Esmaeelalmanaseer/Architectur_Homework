namespace Architectur_Homework
{
    partial class FrmOrder
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
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.checkBox_Strawberries = new System.Windows.Forms.CheckBox();
            this.checkBox_Mango = new System.Windows.Forms.CheckBox();
            this.checkBox_Orange = new System.Windows.Forms.CheckBox();
            this.checkBox_Arabic = new System.Windows.Forms.CheckBox();
            this.comboBox_Quantity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstQty = new System.Windows.Forms.ListBox();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstSuTotal = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOut.Location = new System.Drawing.Point(639, 27);
            this.txtCheckOut.Multiline = true;
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(114, 204);
            this.txtCheckOut.TabIndex = 1;
            // 
            // checkBox_Strawberries
            // 
            this.checkBox_Strawberries.AutoSize = true;
            this.checkBox_Strawberries.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Strawberries.Location = new System.Drawing.Point(8, 56);
            this.checkBox_Strawberries.Name = "checkBox_Strawberries";
            this.checkBox_Strawberries.Size = new System.Drawing.Size(122, 25);
            this.checkBox_Strawberries.TabIndex = 2;
            this.checkBox_Strawberries.Text = "Strawberries";
            this.checkBox_Strawberries.UseVisualStyleBackColor = true;
            // 
            // checkBox_Mango
            // 
            this.checkBox_Mango.AutoSize = true;
            this.checkBox_Mango.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Mango.Location = new System.Drawing.Point(8, 81);
            this.checkBox_Mango.Name = "checkBox_Mango";
            this.checkBox_Mango.Size = new System.Drawing.Size(81, 25);
            this.checkBox_Mango.TabIndex = 3;
            this.checkBox_Mango.Text = "Mango";
            this.checkBox_Mango.UseVisualStyleBackColor = true;
            // 
            // checkBox_Orange
            // 
            this.checkBox_Orange.AutoSize = true;
            this.checkBox_Orange.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Orange.Location = new System.Drawing.Point(8, 31);
            this.checkBox_Orange.Name = "checkBox_Orange";
            this.checkBox_Orange.Size = new System.Drawing.Size(83, 25);
            this.checkBox_Orange.TabIndex = 4;
            this.checkBox_Orange.Text = "Orange";
            this.checkBox_Orange.UseVisualStyleBackColor = true;
            // 
            // checkBox_Arabic
            // 
            this.checkBox_Arabic.AutoSize = true;
            this.checkBox_Arabic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Arabic.Location = new System.Drawing.Point(12, 12);
            this.checkBox_Arabic.Name = "checkBox_Arabic";
            this.checkBox_Arabic.Size = new System.Drawing.Size(79, 25);
            this.checkBox_Arabic.TabIndex = 5;
            this.checkBox_Arabic.Text = "Arabic";
            this.checkBox_Arabic.UseVisualStyleBackColor = true;
            this.checkBox_Arabic.CheckedChanged += new System.EventHandler(this.checkBox_Arabic_CheckedChanged);
            // 
            // comboBox_Quantity
            // 
            this.comboBox_Quantity.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox_Quantity.DropDownHeight = 100;
            this.comboBox_Quantity.DropDownWidth = 100;
            this.comboBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Quantity.FormattingEnabled = true;
            this.comboBox_Quantity.IntegralHeight = false;
            this.comboBox_Quantity.Location = new System.Drawing.Point(87, 246);
            this.comboBox_Quantity.Name = "comboBox_Quantity";
            this.comboBox_Quantity.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Quantity.Sorted = true;
            this.comboBox_Quantity.TabIndex = 6;
            this.comboBox_Quantity.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item Name";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrice.Location = new System.Drawing.Point(87, 278);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 28);
            this.txtPrice.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price";
            // 
            // lstQty
            // 
            this.lstQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQty.FormattingEnabled = true;
            this.lstQty.ItemHeight = 25;
            this.lstQty.Location = new System.Drawing.Point(229, 27);
            this.lstQty.Name = "lstQty";
            this.lstQty.Size = new System.Drawing.Size(123, 204);
            this.lstQty.TabIndex = 7;
            this.lstQty.SelectedIndexChanged += new System.EventHandler(this.lstQty_SelectedIndexChanged);
            // 
            // lstPrice
            // 
            this.lstPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.ItemHeight = 25;
            this.lstPrice.Location = new System.Drawing.Point(358, 27);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(123, 204);
            this.lstPrice.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Strawberries);
            this.groupBox1.Controls.Add(this.checkBox_Mango);
            this.groupBox1.Controls.Add(this.checkBox_Orange);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Grand Total";
            // 
            // lstSuTotal
            // 
            this.lstSuTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuTotal.FormattingEnabled = true;
            this.lstSuTotal.ItemHeight = 25;
            this.lstSuTotal.Location = new System.Drawing.Point(496, 27);
            this.lstSuTotal.Name = "lstSuTotal";
            this.lstSuTotal.Size = new System.Drawing.Size(123, 204);
            this.lstSuTotal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(360, 278);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 28);
            this.txtTotal.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(511, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tax";
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.Info;
            this.txtTax.Enabled = false;
            this.txtTax.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(496, 278);
            this.txtTax.Multiline = true;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(121, 28);
            this.txtTax.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(608, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 24;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(647, 278);
            this.txtGrandTotal.Multiline = true;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(121, 28);
            this.txtGrandTotal.TabIndex = 23;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(214, 246);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(123, 24);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(214, 278);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 28);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Delet";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(501, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Sub Total";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(665, 410);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(123, 34);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 473);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lstSuTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstQty);
            this.Controls.Add(this.comboBox_Quantity);
            this.Controls.Add(this.checkBox_Arabic);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.btn_Add);
            this.Name = "FrmOrder";
            this.Text = "Order Items";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.CheckBox checkBox_Strawberries;
        private System.Windows.Forms.CheckBox checkBox_Mango;
        private System.Windows.Forms.CheckBox checkBox_Orange;
        private System.Windows.Forms.CheckBox checkBox_Arabic;
        private System.Windows.Forms.ComboBox comboBox_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstQty;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstSuTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Save;
    }
}

