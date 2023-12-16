namespace DisabilityApp
{
    partial class VideoShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoShowForm));
            PauseBtn = new Button();
            ResumeBtn = new Button();
            SuspendLayout();
            // 
            // PauseBtn
            // 
            PauseBtn.BackColor = Color.White;
            PauseBtn.BackgroundImage = (Image)resources.GetObject("PauseBtn.BackgroundImage");
            PauseBtn.BackgroundImageLayout = ImageLayout.Zoom;
            PauseBtn.FlatAppearance.BorderSize = 0;
            PauseBtn.FlatStyle = FlatStyle.Flat;
            PauseBtn.Location = new Point(556, 790);
            PauseBtn.Name = "PauseBtn";
            PauseBtn.Size = new Size(83, 65);
            PauseBtn.TabIndex = 0;
            PauseBtn.UseVisualStyleBackColor = false;
            // 
            // ResumeBtn
            // 
            ResumeBtn.BackColor = Color.White;
            ResumeBtn.BackgroundImage = (Image)resources.GetObject("ResumeBtn.BackgroundImage");
            ResumeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            ResumeBtn.FlatAppearance.BorderSize = 0;
            ResumeBtn.FlatStyle = FlatStyle.Flat;
            ResumeBtn.Location = new Point(408, 790);
            ResumeBtn.Name = "ResumeBtn";
            ResumeBtn.Size = new Size(70, 65);
            ResumeBtn.TabIndex = 1;
            ResumeBtn.UseVisualStyleBackColor = false;
            ResumeBtn.Click += ResumeBtn_Click;
            // 
            // VideoShowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1662, 898);
            Controls.Add(ResumeBtn);
            Controls.Add(PauseBtn);
            MaximumSize = new Size(1680, 945);
            MinimumSize = new Size(1680, 945);
            Name = "VideoShowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VideoShowForm";
            ResumeLayout(false);
        }

        #endregion

        private Button PauseBtn;
        private Button ResumeBtn;
    }
}