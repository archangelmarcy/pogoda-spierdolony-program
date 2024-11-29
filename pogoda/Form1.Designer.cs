namespace pogoda
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
            button1 = new Button();
            pogodabox = new RichTextBox();
            temperaturabox = new TextBox();
            label1 = new Label();
            wilgocbox = new TextBox();
            wilgoclabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(219, 312);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pogodabox
            // 
            pogodabox.Location = new Point(37, 194);
            pogodabox.Name = "pogodabox";
            pogodabox.Size = new Size(443, 67);
            pogodabox.TabIndex = 1;
            pogodabox.Text = "";
            // 
            // temperaturabox
            // 
            temperaturabox.Location = new Point(380, 29);
            temperaturabox.Name = "temperaturabox";
            temperaturabox.Size = new Size(100, 23);
            temperaturabox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Temperatura:";
            // 
            // wilgocbox
            // 
            wilgocbox.Location = new Point(380, 67);
            wilgocbox.Name = "wilgocbox";
            wilgocbox.Size = new Size(100, 23);
            wilgocbox.TabIndex = 4;
            // 
            // wilgoclabel
            // 
            wilgoclabel.AutoSize = true;
            wilgoclabel.Location = new Point(327, 70);
            wilgoclabel.Name = "wilgoclabel";
            wilgoclabel.Size = new Size(47, 15);
            wilgoclabel.TabIndex = 5;
            wilgoclabel.Text = "Wilgoc:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 411);
            Controls.Add(wilgoclabel);
            Controls.Add(wilgocbox);
            Controls.Add(label1);
            Controls.Add(temperaturabox);
            Controls.Add(pogodabox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox pogodabox;
        private TextBox temperaturabox;
        private Label label1;
        private TextBox wilgocbox;
        private Label wilgoclabel;
    }
}
