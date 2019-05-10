namespace FifaApi
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
			this.getDataButton = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// getDataButton
			// 
			this.getDataButton.Location = new System.Drawing.Point(12, 333);
			this.getDataButton.Name = "getDataButton";
			this.getDataButton.Size = new System.Drawing.Size(248, 35);
			this.getDataButton.TabIndex = 0;
			this.getDataButton.Text = "Get Data";
			this.getDataButton.UseVisualStyleBackColor = true;
			this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 16;
			this.listBox.Location = new System.Drawing.Point(12, 12);
			this.listBox.MultiColumn = true;
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(248, 308);
			this.listBox.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 377);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.getDataButton);
			this.Name = "Form1";
			this.Text = "FIFA API";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.ListBox listBox;
    }
}

