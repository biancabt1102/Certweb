namespace Certweb
{
    partial class Links
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Links));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnFlowLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtDescricao
            // 
            resources.ApplyResources(this.txtDescricao, "txtDescricao");
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // txtLink
            // 
            resources.ApplyResources(this.txtLink, "txtLink");
            this.txtLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtLink.Name = "txtLink";
            this.txtLink.Enter += new System.EventHandler(this.txtLink_Enter);
            this.txtLink.Leave += new System.EventHandler(this.txtLink_Leave);
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnFlowLinks
            // 
            resources.ApplyResources(this.pnFlowLinks, "pnFlowLinks");
            this.pnFlowLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFlowLinks.Name = "pnFlowLinks";
            // 
            // Links
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnFlowLinks);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Name = "Links";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.FlowLayoutPanel pnFlowLinks;
    }
}
