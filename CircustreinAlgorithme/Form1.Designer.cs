namespace CircustreinAlgorithme
{
    partial class Form1
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
            this.Divide = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Race = new System.Windows.Forms.ComboBox();
            this.Size = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(679, 403);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 0;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(29, 403);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Race
            // 
            this.Race.FormattingEnabled = true;
            this.Race.Items.AddRange(new object[] {
            "Herbivore",
            "Carnivore"});
            this.Race.Location = new System.Drawing.Point(94, 257);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(121, 24);
            this.Race.TabIndex = 2;
            // 
            // Size
            // 
            this.Size.FormattingEnabled = true;
            this.Size.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.Size.Location = new System.Drawing.Point(94, 304);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(121, 24);
            this.Size.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Race";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Divide);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox Race;
        private System.Windows.Forms.ComboBox Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

