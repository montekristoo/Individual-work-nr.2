namespace Individual_work_nr._2
{
    partial class ShowResultForm
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
            this.display_result_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display_result_label
            // 
            this.display_result_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display_result_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.display_result_label.Location = new System.Drawing.Point(124, 48);
            this.display_result_label.Name = "display_result_label";
            this.display_result_label.Size = new System.Drawing.Size(582, 318);
            this.display_result_label.TabIndex = 0;
            this.display_result_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.display_result_label);
            this.Name = "ShowResultForm";
            this.Text = "ShowResultForm";
            this.Load += new System.EventHandler(this.ShowResultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label display_result_label;
    }
}