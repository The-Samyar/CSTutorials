namespace SortForm
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
            textBox = new TextBox();
            SuspendLayout();
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(350, 283);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 278);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 4;
            label2.Text = "Sorted result:";
            // 
            // button1
            // 
            button1.Location = new Point(363, 202);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 118);
            label1.Name = "label1";
            label1.Size = new Size(316, 21);
            label1.TabIndex = 0;
            label1.Text = "Type in some integers, separated by comma:";
            // 
            // textBox
            // 
            textBox.Location = new Point(242, 142);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.PlaceholderText = "43, 6, 76, 3, ....";
            textBox.Size = new Size(316, 54);
            textBox.TabIndex = 1;
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
            Controls.Add(textBox);
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
        private TextBox textBox;
    }
}
