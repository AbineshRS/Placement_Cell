﻿namespace Placement_Cell
{
    partial class Login
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(867, 283);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(867, 337);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(990, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 34);
            textBox1.TabIndex = 2;
            textBox1.Text = "Admin";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(990, 335);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 34);
            textBox2.TabIndex = 3;
            textBox2.Text = "pwd";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(857, 400);
            button1.Name = "button1";
            button1.Size = new Size(111, 45);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(974, 400);
            button2.Name = "button2";
            button2.Size = new Size(118, 45);
            button2.TabIndex = 5;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(1098, 403);
            button3.Name = "button3";
            button3.Size = new Size(115, 42);
            button3.TabIndex = 6;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(859, 472);
            label3.Name = "label3";
            label3.Size = new Size(233, 38);
            label3.TabIndex = 7;
            label3.Text = "Student Register?";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 517);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}