namespace HLM2
{
    partial class MainMenu
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MainMenuTitle = new System.Windows.Forms.Label();
            this.LoadLinesBtn = new System.Windows.Forms.Button();
            this.NewLinesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainMenuTitle
            // 
            this.MainMenuTitle.AutoSize = true;
            this.MainMenuTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuTitle.Location = new System.Drawing.Point(154, 23);
            this.MainMenuTitle.Name = "MainMenuTitle";
            this.MainMenuTitle.Size = new System.Drawing.Size(474, 50);
            this.MainMenuTitle.TabIndex = 0;
            this.MainMenuTitle.Text = "Hockey Lineup Manager 2";
            // 
            // LoadLinesBtn
            // 
            this.LoadLinesBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadLinesBtn.Location = new System.Drawing.Point(54, 113);
            this.LoadLinesBtn.Name = "LoadLinesBtn";
            this.LoadLinesBtn.Size = new System.Drawing.Size(308, 125);
            this.LoadLinesBtn.TabIndex = 1;
            this.LoadLinesBtn.Text = "Load Lines";
            this.LoadLinesBtn.UseVisualStyleBackColor = true;
            this.LoadLinesBtn.Click += new System.EventHandler(this.LoadLinesBtn_Click);
            // 
            // NewLinesBtn
            // 
            this.NewLinesBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewLinesBtn.Location = new System.Drawing.Point(437, 113);
            this.NewLinesBtn.Name = "NewLinesBtn";
            this.NewLinesBtn.Size = new System.Drawing.Size(308, 125);
            this.NewLinesBtn.TabIndex = 2;
            this.NewLinesBtn.Text = "New Lines";
            this.NewLinesBtn.UseVisualStyleBackColor = true;
            this.NewLinesBtn.Click += new System.EventHandler(this.NewLinesBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.NewLinesBtn);
            this.Controls.Add(this.LoadLinesBtn);
            this.Controls.Add(this.MainMenuTitle);
            this.Name = "MainMenu";
            this.Text = "HLM2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label MainMenuTitle;
        private System.Windows.Forms.Button LoadLinesBtn;
        private System.Windows.Forms.Button NewLinesBtn;
    }
}
