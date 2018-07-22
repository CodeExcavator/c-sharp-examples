namespace c_sharp_features
{
    partial class MainForm
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
            this.btnDelegates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelegates
            // 
            this.btnDelegates.Location = new System.Drawing.Point(12, 12);
            this.btnDelegates.Name = "btnDelegates";
            this.btnDelegates.Size = new System.Drawing.Size(75, 23);
            this.btnDelegates.TabIndex = 0;
            this.btnDelegates.Text = "Delegates";
            this.btnDelegates.UseVisualStyleBackColor = true;
            this.btnDelegates.Click += new System.EventHandler(this.btnDelegates_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelegates);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelegates;
    }
}