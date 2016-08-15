namespace Image_List
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListViewImg = new System.Windows.Forms.ListView();
            this.DesignerImageList = new System.Windows.Forms.ImageList(this.components);
            this.BtnUseDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewImg
            // 
            this.ListViewImg.Location = new System.Drawing.Point(12, 12);
            this.ListViewImg.Name = "ListViewImg";
            this.ListViewImg.Size = new System.Drawing.Size(670, 360);
            this.ListViewImg.TabIndex = 0;
            this.ListViewImg.UseCompatibleStateImageBehavior = false;
            // 
            // DesignerImageList
            // 
            this.DesignerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DesignerImageList.ImageStream")));
            this.DesignerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DesignerImageList.Images.SetKeyName(0, "13680526_1044235095683907_8343917858642614944_n.jpg");
            this.DesignerImageList.Images.SetKeyName(1, "13690682_1046443145463102_2918472533128964567_n.png");
            this.DesignerImageList.Images.SetKeyName(2, "af6b0d61-f146-4c28-acf6-3300d4eb4a44.jpg");
            this.DesignerImageList.Images.SetKeyName(3, "Are-You-Fucking-Kidding-Me-Rage-Face-Meme-Temp.png");
            this.DesignerImageList.Images.SetKeyName(4, "g4320.png");
            this.DesignerImageList.Images.SetKeyName(5, "intro logo.png");
            // 
            // BtnUseDialog
            // 
            this.BtnUseDialog.Location = new System.Drawing.Point(13, 379);
            this.BtnUseDialog.Name = "BtnUseDialog";
            this.BtnUseDialog.Size = new System.Drawing.Size(75, 23);
            this.BtnUseDialog.TabIndex = 1;
            this.BtnUseDialog.Text = "Use Dialog";
            this.BtnUseDialog.UseVisualStyleBackColor = true;
            this.BtnUseDialog.Click += new System.EventHandler(this.BtnUseDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 428);
            this.Controls.Add(this.BtnUseDialog);
            this.Controls.Add(this.ListViewImg);
            this.Name = "Form1";
            this.Text = "Image ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewImg;
        private System.Windows.Forms.ImageList DesignerImageList;
        private System.Windows.Forms.Button BtnUseDialog;
    }
}

