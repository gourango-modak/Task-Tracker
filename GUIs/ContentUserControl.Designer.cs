﻿namespace Task_Manager
{
    partial class ContentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentUserControl));
            this.panel1Today = new System.Windows.Forms.Panel();
            this.pictureBox2Today = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1Today = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1Today.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Today)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1Today
            // 
            this.panel1Today.Controls.Add(this.pictureBox2Today);
            this.panel1Today.Controls.Add(this.label1);
            this.panel1Today.Location = new System.Drawing.Point(28, 3);
            this.panel1Today.Name = "panel1Today";
            this.panel1Today.Size = new System.Drawing.Size(759, 52);
            this.panel1Today.TabIndex = 9;
            // 
            // pictureBox2Today
            // 
            this.pictureBox2Today.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2Today.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2Today.Image")));
            this.pictureBox2Today.Location = new System.Drawing.Point(711, 21);
            this.pictureBox2Today.Name = "pictureBox2Today";
            this.pictureBox2Today.Size = new System.Drawing.Size(22, 24);
            this.pictureBox2Today.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Today.TabIndex = 15;
            this.pictureBox2Today.TabStop = false;
            this.pictureBox2Today.Click += new System.EventHandler(this.pictureBox2Today_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // flowLayoutPanel1Today
            // 
            this.flowLayoutPanel1Today.AutoScroll = true;
            this.flowLayoutPanel1Today.Location = new System.Drawing.Point(28, 58);
            this.flowLayoutPanel1Today.Name = "flowLayoutPanel1Today";
            this.flowLayoutPanel1Today.Size = new System.Drawing.Size(788, 488);
            this.flowLayoutPanel1Today.TabIndex = 8;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlSetting);
            this.pnlContent.Controls.Add(this.panel1Today);
            this.pnlContent.Controls.Add(this.flowLayoutPanel1Today);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(787, 546);
            this.pnlContent.TabIndex = 7;
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.button8);
            this.pnlSetting.Controls.Add(this.button7);
            this.pnlSetting.Controls.Add(this.button6);
            this.pnlSetting.Controls.Add(this.button5);
            this.pnlSetting.Controls.Add(this.button4);
            this.pnlSetting.Controls.Add(this.button3);
            this.pnlSetting.Controls.Add(this.button2);
            this.pnlSetting.Location = new System.Drawing.Point(495, 58);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(266, 228);
            this.pnlSetting.TabIndex = 7;
            this.pnlSetting.Visible = false;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(0, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(265, 34);
            this.button8.TabIndex = 19;
            this.button8.Text = "Share";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(265, 34);
            this.button7.TabIndex = 18;
            this.button7.Text = "Import Template";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(0, 129);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(265, 34);
            this.button6.TabIndex = 17;
            this.button6.Text = "Export Template";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(265, 34);
            this.button5.TabIndex = 16;
            this.button5.Text = "Show Completed Task";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 34);
            this.button4.TabIndex = 15;
            this.button4.Text = "Sort By Priority";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 34);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sort By Tittle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sort By Date";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Name = "ContentUserControl";
            this.Size = new System.Drawing.Size(787, 546);
            this.panel1Today.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Today)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1Today;
        private System.Windows.Forms.PictureBox pictureBox2Today;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1Today;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
