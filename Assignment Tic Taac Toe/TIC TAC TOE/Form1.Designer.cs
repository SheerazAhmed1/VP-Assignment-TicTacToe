namespace TIC_TAC_TOE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.R1B1 = new System.Windows.Forms.Button();
            this.R1B2 = new System.Windows.Forms.Button();
            this.R1B3 = new System.Windows.Forms.Button();
            this.R2B1 = new System.Windows.Forms.Button();
            this.R2B2 = new System.Windows.Forms.Button();
            this.R2B3 = new System.Windows.Forms.Button();
            this.R3B1 = new System.Windows.Forms.Button();
            this.R3B2 = new System.Windows.Forms.Button();
            this.R3B3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // R1B1
            // 
            this.R1B1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1B1.Location = new System.Drawing.Point(75, 64);
            this.R1B1.Name = "R1B1";
            this.R1B1.Size = new System.Drawing.Size(100, 100);
            this.R1B1.TabIndex = 1;
            this.R1B1.UseVisualStyleBackColor = true;
            this.R1B1.Click += new System.EventHandler(this.button_click);
            // 
            // R1B2
            // 
            this.R1B2.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1B2.Location = new System.Drawing.Point(202, 64);
            this.R1B2.Name = "R1B2";
            this.R1B2.Size = new System.Drawing.Size(100, 100);
            this.R1B2.TabIndex = 1;
            this.R1B2.UseVisualStyleBackColor = true;
            this.R1B2.Click += new System.EventHandler(this.button_click);
            // 
            // R1B3
            // 
            this.R1B3.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1B3.Location = new System.Drawing.Point(333, 64);
            this.R1B3.Name = "R1B3";
            this.R1B3.Size = new System.Drawing.Size(100, 100);
            this.R1B3.TabIndex = 1;
            this.R1B3.UseVisualStyleBackColor = true;
            this.R1B3.Click += new System.EventHandler(this.button_click);
            // 
            // R2B1
            // 
            this.R2B1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2B1.Location = new System.Drawing.Point(75, 170);
            this.R2B1.Name = "R2B1";
            this.R2B1.Size = new System.Drawing.Size(100, 100);
            this.R2B1.TabIndex = 1;
            this.R2B1.UseVisualStyleBackColor = true;
            this.R2B1.Click += new System.EventHandler(this.button_click);
            // 
            // R2B2
            // 
            this.R2B2.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2B2.Location = new System.Drawing.Point(202, 170);
            this.R2B2.Name = "R2B2";
            this.R2B2.Size = new System.Drawing.Size(100, 100);
            this.R2B2.TabIndex = 1;
            this.R2B2.UseVisualStyleBackColor = true;
            this.R2B2.Click += new System.EventHandler(this.button_click);
            // 
            // R2B3
            // 
            this.R2B3.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2B3.Location = new System.Drawing.Point(333, 170);
            this.R2B3.Name = "R2B3";
            this.R2B3.Size = new System.Drawing.Size(100, 100);
            this.R2B3.TabIndex = 1;
            this.R2B3.UseVisualStyleBackColor = true;
            this.R2B3.Click += new System.EventHandler(this.button_click);
            // 
            // R3B1
            // 
            this.R3B1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3B1.Location = new System.Drawing.Point(75, 276);
            this.R3B1.Name = "R3B1";
            this.R3B1.Size = new System.Drawing.Size(100, 100);
            this.R3B1.TabIndex = 1;
            this.R3B1.UseVisualStyleBackColor = true;
            this.R3B1.Click += new System.EventHandler(this.button_click);
            // 
            // R3B2
            // 
            this.R3B2.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3B2.Location = new System.Drawing.Point(202, 276);
            this.R3B2.Name = "R3B2";
            this.R3B2.Size = new System.Drawing.Size(100, 100);
            this.R3B2.TabIndex = 1;
            this.R3B2.UseVisualStyleBackColor = true;
            this.R3B2.Click += new System.EventHandler(this.button_click);
            // 
            // R3B3
            // 
            this.R3B3.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3B3.Location = new System.Drawing.Point(333, 276);
            this.R3B3.Name = "R3B3";
            this.R3B3.Size = new System.Drawing.Size(100, 100);
            this.R3B3.TabIndex = 1;
            this.R3B3.UseVisualStyleBackColor = true;
            this.R3B3.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 420);
            this.Controls.Add(this.R3B3);
            this.Controls.Add(this.R2B3);
            this.Controls.Add(this.R1B3);
            this.Controls.Add(this.R3B2);
            this.Controls.Add(this.R3B1);
            this.Controls.Add(this.R2B2);
            this.Controls.Add(this.R2B1);
            this.Controls.Add(this.R1B2);
            this.Controls.Add(this.R1B1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button R1B1;
        private Button R1B2;
        private Button R1B3;
        private Button R2B1;
        private Button R2B2;
        private Button R2B3;
        private Button R3B1;
        private Button R3B2;
        private Button R3B3;
    }

}