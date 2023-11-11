namespace U3_Practica_5
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
            listBox1 = new ListBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 0;
            label1.Text = "Genera los números del";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightCoral;
            listBox1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(58, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 202);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(75, 308);
            button1.Name = "button1";
            button1.Size = new Size(108, 39);
            button1.TabIndex = 2;
            button1.Text = "Generar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 3;
            label2.Text = "1 al 20 con While";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(277, 368);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private Label label2;
    }
}