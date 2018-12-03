namespace GenealoTree
{
    partial class RelationshipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelationshipForm));
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(12, 427);
            this.homeButton.MaximumSize = new System.Drawing.Size(100, 30);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(100, 30);
            this.homeButton.TabIndex = 71;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // RelationshipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(507, 469);
            this.Controls.Add(this.homeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelationshipForm";
            this.Text = "Relationship View";
            this.Load += new System.EventHandler(this.SelectionViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
    }
}