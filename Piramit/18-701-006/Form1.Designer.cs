namespace _18_701_006
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
            this.OpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.buttonDondur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenGlControl
            // 
            this.OpenGlControl.AccumBits = ((byte)(0));
            this.OpenGlControl.AutoCheckErrors = false;
            this.OpenGlControl.AutoFinish = false;
            this.OpenGlControl.AutoMakeCurrent = true;
            this.OpenGlControl.AutoSwapBuffers = true;
            this.OpenGlControl.BackColor = System.Drawing.Color.Black;
            this.OpenGlControl.ColorBits = ((byte)(32));
            this.OpenGlControl.DepthBits = ((byte)(16));
            this.OpenGlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenGlControl.Location = new System.Drawing.Point(0, 0);
            this.OpenGlControl.Name = "OpenGlControl";
            this.OpenGlControl.Size = new System.Drawing.Size(700, 585);
            this.OpenGlControl.StencilBits = ((byte)(0));
            this.OpenGlControl.TabIndex = 0;
            this.OpenGlControl.Load += new System.EventHandler(this.OpenGlControl_Load);
            this.OpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPaint);
            this.OpenGlControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // buttonDondur
            // 
            this.buttonDondur.Location = new System.Drawing.Point(779, 323);
            this.buttonDondur.Name = "buttonDondur";
            this.buttonDondur.Size = new System.Drawing.Size(155, 57);
            this.buttonDondur.TabIndex = 1;
            this.buttonDondur.Text = "Döndür";
            this.buttonDondur.UseVisualStyleBackColor = true;
            this.buttonDondur.Click += new System.EventHandler(this.buttonDondur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 585);
            this.Controls.Add(this.buttonDondur);
            this.Controls.Add(this.OpenGlControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControl;
        private System.Windows.Forms.Button buttonDondur;
    }
}

