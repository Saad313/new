namespace client
{
    partial class AddPost
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
            this.lblposttitle = new System.Windows.Forms.Label();
            this.lblpostcategory = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblapprovelrequest = new System.Windows.Forms.LinkLabel();
            this.txtposttitle = new System.Windows.Forms.TextBox();
            this.txtpostcategory = new System.Windows.Forms.TextBox();
            this.txtpostdescription = new System.Windows.Forms.TextBox();
            this.lbladdpost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblposttitle
            // 
            this.lblposttitle.AutoSize = true;
            this.lblposttitle.Location = new System.Drawing.Point(47, 48);
            this.lblposttitle.Name = "lblposttitle";
            this.lblposttitle.Size = new System.Drawing.Size(51, 13);
            this.lblposttitle.TabIndex = 0;
            this.lblposttitle.Text = "Post Title";
            // 
            // lblpostcategory
            // 
            this.lblpostcategory.AutoSize = true;
            this.lblpostcategory.Location = new System.Drawing.Point(47, 108);
            this.lblpostcategory.Name = "lblpostcategory";
            this.lblpostcategory.Size = new System.Drawing.Size(73, 13);
            this.lblpostcategory.TabIndex = 1;
            this.lblpostcategory.Text = "Post Category";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(47, 174);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(60, 13);
            this.lbldescription.TabIndex = 2;
            this.lbldescription.Text = "Description";
            // 
            // lblapprovelrequest
            // 
            this.lblapprovelrequest.AutoSize = true;
            this.lblapprovelrequest.Location = new System.Drawing.Point(47, 252);
            this.lblapprovelrequest.Name = "lblapprovelrequest";
            this.lblapprovelrequest.Size = new System.Drawing.Size(92, 13);
            this.lblapprovelrequest.TabIndex = 3;
            this.lblapprovelrequest.TabStop = true;
            this.lblapprovelrequest.Text = "Approvel Request";
            this.lblapprovelrequest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblapprovelrequest_LinkClicked);
            // 
            // txtposttitle
            // 
            this.txtposttitle.Location = new System.Drawing.Point(196, 45);
            this.txtposttitle.Name = "txtposttitle";
            this.txtposttitle.Size = new System.Drawing.Size(100, 20);
            this.txtposttitle.TabIndex = 4;
            // 
            // txtpostcategory
            // 
            this.txtpostcategory.Location = new System.Drawing.Point(196, 108);
            this.txtpostcategory.Name = "txtpostcategory";
            this.txtpostcategory.Size = new System.Drawing.Size(100, 20);
            this.txtpostcategory.TabIndex = 5;
            // 
            // txtpostdescription
            // 
            this.txtpostdescription.Location = new System.Drawing.Point(196, 153);
            this.txtpostdescription.Multiline = true;
            this.txtpostdescription.Name = "txtpostdescription";
            this.txtpostdescription.Size = new System.Drawing.Size(158, 93);
            this.txtpostdescription.TabIndex = 6;
            // 
            // lbladdpost
            // 
            this.lbladdpost.Location = new System.Drawing.Point(221, 252);
            this.lbladdpost.Name = "lbladdpost";
            this.lbladdpost.Size = new System.Drawing.Size(75, 23);
            this.lbladdpost.TabIndex = 7;
            this.lbladdpost.Text = "Add Post";
            this.lbladdpost.UseVisualStyleBackColor = true;
            this.lbladdpost.Click += new System.EventHandler(this.lbladdpost_Click);
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 339);
            this.Controls.Add(this.lbladdpost);
            this.Controls.Add(this.txtpostdescription);
            this.Controls.Add(this.txtpostcategory);
            this.Controls.Add(this.txtposttitle);
            this.Controls.Add(this.lblapprovelrequest);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblpostcategory);
            this.Controls.Add(this.lblposttitle);
            this.Name = "AddPost";
            this.Text = "AddPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblposttitle;
        private System.Windows.Forms.Label lblpostcategory;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.LinkLabel lblapprovelrequest;
        private System.Windows.Forms.TextBox txtposttitle;
        private System.Windows.Forms.TextBox txtpostcategory;
        private System.Windows.Forms.TextBox txtpostdescription;
        private System.Windows.Forms.Button lbladdpost;
    }
}