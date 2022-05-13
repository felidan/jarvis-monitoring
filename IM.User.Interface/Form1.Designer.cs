namespace IM.User.Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_hello = new System.Windows.Forms.Label();
            this.lbl_next_update = new System.Windows.Forms.Label();
            this.panelIntegration = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_last_update = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.panelInte = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_hello
            // 
            this.lbl_hello.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hello.Location = new System.Drawing.Point(587, 9);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(114, 29);
            this.lbl_hello.TabIndex = 0;
            this.lbl_hello.Text = "lbl_hello";
            this.lbl_hello.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_next_update
            // 
            this.lbl_next_update.AutoSize = true;
            this.lbl_next_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_next_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_next_update.Location = new System.Drawing.Point(12, 9);
            this.lbl_next_update.Name = "lbl_next_update";
            this.lbl_next_update.Size = new System.Drawing.Size(125, 20);
            this.lbl_next_update.TabIndex = 1;
            this.lbl_next_update.Text = "lbl_next_update";
            // 
            // panelIntegration
            // 
            this.panelIntegration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIntegration.AutoScroll = true;
            this.panelIntegration.Location = new System.Drawing.Point(16, 60);
            this.panelIntegration.Name = "panelIntegration";
            this.panelIntegration.Size = new System.Drawing.Size(1414, 0);
            this.panelIntegration.TabIndex = 2;
            this.panelIntegration.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIntegration_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Integrations";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1335, 1349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Felipe Dantas";
            // 
            // lbl_last_update
            // 
            this.lbl_last_update.AutoSize = true;
            this.lbl_last_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_update.ForeColor = System.Drawing.Color.Blue;
            this.lbl_last_update.Location = new System.Drawing.Point(13, 33);
            this.lbl_last_update.Name = "lbl_last_update";
            this.lbl_last_update.Size = new System.Drawing.Size(0, 20);
            this.lbl_last_update.TabIndex = 4;
            this.lbl_last_update.UseMnemonic = false;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1322, 6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 47);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update Now";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panelInte
            // 
            this.panelInte.Location = new System.Drawing.Point(19, 60);
            this.panelInte.Name = "panelInte";
            this.panelInte.Size = new System.Drawing.Size(1408, 664);
            this.panelInte.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1329, 715);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Felipe Dantas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1442, 746);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_last_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIntegration);
            this.Controls.Add(this.lbl_next_update);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.panelInte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1460, 793);
            this.MinimumSize = new System.Drawing.Size(1460, 793);
            this.Name = "Form1";
            this.Text = "J.A.R.V.I.S - Integration Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Label lbl_next_update;
        private System.Windows.Forms.Panel panelIntegration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_last_update;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panelInte;
        private System.Windows.Forms.Label label3;
    }
}

