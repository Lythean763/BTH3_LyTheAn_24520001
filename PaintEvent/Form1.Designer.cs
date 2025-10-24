namespace PaintEvent
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
            btnRef = new Button();
            SuspendLayout();
            // 
            // btnRef
            // 
            btnRef.BackColor = Color.Yellow;
            btnRef.Location = new Point(60, 40);
            btnRef.Name = "btnRef";
            btnRef.Size = new Size(127, 58);
            btnRef.TabIndex = 0;
            btnRef.UseVisualStyleBackColor = false;
            btnRef.Click += btnRef_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRef);
            Name = "Form1";
            Text = "Minh họa sự kiện Paint trên Form";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRef;
    }
}
