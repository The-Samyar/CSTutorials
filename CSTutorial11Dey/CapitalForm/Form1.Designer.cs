namespace CapitalForm
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
            result = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(411, 301);
            result.Name = "result";
            result.Size = new Size(22, 15);
            result.TabIndex = 9;
            result.Text = "res";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 301);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "Result:";
            // 
            // button1
            // 
            button1.Location = new Point(355, 240);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 134);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 6;
            label1.Text = "Type some text";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label result;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}
