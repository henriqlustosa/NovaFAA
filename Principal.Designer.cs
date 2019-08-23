namespace ImpFAA
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtFaa = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleDescription = null;
            this.btnPrint.AccessibleName = null;
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.BackgroundImage = null;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseCompatibleTextRendering = true;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblError
            // 
            this.lblError.AccessibleDescription = null;
            this.lblError.AccessibleName = null;
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Name = "lblError";
            // 
            // txtFaa
            // 
            this.txtFaa.AccessibleDescription = null;
            this.txtFaa.AccessibleName = null;
            resources.ApplyResources(this.txtFaa, "txtFaa");
            this.txtFaa.BackgroundImage = null;
            this.txtFaa.BeepOnError = true;
            this.txtFaa.Name = "txtFaa";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // Principal
            // 
            this.AcceptButton = this.btnPrint;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFaa);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.MaskedTextBox txtFaa;
        private System.Windows.Forms.Label label2;
    }
}

