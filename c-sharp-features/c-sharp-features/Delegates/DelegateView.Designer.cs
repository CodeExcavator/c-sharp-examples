namespace c_sharp_features.Delegates
{
    partial class DelegateView
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtrack = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnWithMsg = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(12, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(118, 12);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 39);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(409, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Use the buttons below to change how the WeirdCaluculator will process two numbers" +
    "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtrack
            // 
            this.btnSubtrack.Location = new System.Drawing.Point(118, 82);
            this.btnSubtrack.Name = "btnSubtrack";
            this.btnSubtrack.Size = new System.Drawing.Size(100, 23);
            this.btnSubtrack.TabIndex = 4;
            this.btnSubtrack.Text = "Subtract";
            this.btnSubtrack.UseVisualStyleBackColor = true;
            this.btnSubtrack.Click += new System.EventHandler(this.btnSubtrack_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(16, 156);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // btnWithMsg
            // 
            this.btnWithMsg.Location = new System.Drawing.Point(225, 82);
            this.btnWithMsg.Name = "btnWithMsg";
            this.btnWithMsg.Size = new System.Drawing.Size(197, 23);
            this.btnWithMsg.TabIndex = 6;
            this.btnWithMsg.Text = "Last Action with Msg";
            this.btnWithMsg.UseVisualStyleBackColor = true;
            this.btnWithMsg.Click += new System.EventHandler(this.btnWithMsg_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(12, 111);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(100, 23);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // DelegateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 221);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnWithMsg);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubtrack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "DelegateView";
            this.Text = "Delegate Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtrack;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnWithMsg;
        private System.Windows.Forms.Button btnMultiply;
    }
}