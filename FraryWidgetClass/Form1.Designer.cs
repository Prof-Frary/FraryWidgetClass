﻿namespace FraryWidgetClass
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrice = new TextBox();
            cboColor = new ComboBox();
            cboSize = new ComboBox();
            btnAdd = new Button();
            lstOut = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 79);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 119);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 168);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 3;
            label3.Text = "Size";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 204);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(144, 201);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 5;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(144, 116);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(121, 23);
            cboColor.TabIndex = 6;
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Location = new Point(144, 160);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(121, 23);
            cboSize.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(144, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 47);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Widget";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.HorizontalScrollbar = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(12, 333);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(330, 94);
            lstOut.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(lstOut);
            Controls.Add(btnAdd);
            Controls.Add(cboSize);
            Controls.Add(cboColor);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Widget Entry - Your Name";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrice;
        private ComboBox cboColor;
        private ComboBox cboSize;
        private Button btnAdd;
        private ListBox lstOut;
    }
}
