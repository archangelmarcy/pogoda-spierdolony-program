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
            pogodawmo = new TextBox();
            label2 = new Label();
            wiatrspeed = new TextBox();
            wiatrdirection = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(225, 358);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "OBSRAJ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pogodabox
            // 
            pogodabox.Location = new Point(37, 285);
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
            // pogodawmo
            // 
            pogodawmo.Location = new Point(380, 107);
            pogodawmo.Name = "pogodawmo";
            pogodawmo.Size = new Size(100, 23);
            pogodawmo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 110);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Obecnie jest:";
            // 
            // wiatrspeed
            // 
            wiatrspeed.Location = new Point(380, 146);
            wiatrspeed.Name = "wiatrspeed";
            wiatrspeed.Size = new Size(100, 23);
            wiatrspeed.TabIndex = 8;
            // 
            // wiatrdirection
            // 
            wiatrdirection.Location = new Point(380, 187);
            wiatrdirection.Name = "wiatrdirection";
            wiatrdirection.Size = new Size(100, 23);
            wiatrdirection.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 149);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 10;
            label3.Text = "Predkosc Wiatru:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 190);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 11;
            label4.Text = "Kierunek Wiatru:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 267);
            label5.Name = "label5";
            label5.Size = new Size(252, 15);
            label5.TabIndex = 12;
            label5.Text = "CENTRUM DOWODZENIA JSON BY ZAWADZKI";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "DODAC BASSU?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.zawadzki;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(513, 411);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(wiatrdirection);
            Controls.Add(wiatrspeed);
            Controls.Add(label2);
            Controls.Add(pogodawmo);
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
        private TextBox pogodawmo;
        private Label label2;
        private TextBox wiatrspeed;
        private TextBox wiatrdirection;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
    }
}
