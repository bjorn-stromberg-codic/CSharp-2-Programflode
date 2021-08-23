
namespace WinForms_App
{
    partial class MyForm
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
            this.MyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyButton
            // 
            this.MyButton.Location = new System.Drawing.Point(292, 183);
            this.MyButton.Name = "MyButton";
            this.MyButton.Size = new System.Drawing.Size(204, 34);
            this.MyButton.TabIndex = 0;
            this.MyButton.Text = "My Button";
            this.MyButton.UseVisualStyleBackColor = true;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyButton);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MyButton;
    }
}

