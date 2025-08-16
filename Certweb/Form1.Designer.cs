namespace Certweb
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.pnDragDrop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnIndicador = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnPainelTarefas = new System.Windows.Forms.Button();
            this.btnPainel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.CertwebSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuSystemTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTarefas = new Certweb.Tarefas();
            this.pnLinks = new Certweb.Links();
            this.pnPainel = new Certweb.Painel();
            this.pnSobre = new Certweb.Sobre();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MenuSystemTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDragDrop
            // 
            resources.ApplyResources(this.pnDragDrop, "pnDragDrop");
            this.pnDragDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pnDragDrop.Name = "pnDragDrop";
            this.pnDragDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnDragDrop_MouseDown);
            this.pnDragDrop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnDragDrop_MouseMove);
            this.pnDragDrop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnDragDrop_MouseUp);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pnIndicador);
            this.panel2.Controls.Add(this.btnSobre);
            this.panel2.Controls.Add(this.btnLink);
            this.panel2.Controls.Add(this.btnPainelTarefas);
            this.panel2.Controls.Add(this.btnPainel);
            this.panel2.Name = "panel2";
            // 
            // pnIndicador
            // 
            resources.ApplyResources(this.pnIndicador, "pnIndicador");
            this.pnIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pnIndicador.Name = "pnIndicador";
            // 
            // btnSobre
            // 
            resources.ApplyResources(this.btnSobre, "btnSobre");
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnClickSobre);
            // 
            // btnLink
            // 
            resources.ApplyResources(this.btnLink, "btnLink");
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.ForeColor = System.Drawing.Color.White;
            this.btnLink.Name = "btnLink";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnClickLink);
            // 
            // btnPainelTarefas
            // 
            resources.ApplyResources(this.btnPainelTarefas, "btnPainelTarefas");
            this.btnPainelTarefas.FlatAppearance.BorderSize = 0;
            this.btnPainelTarefas.ForeColor = System.Drawing.Color.White;
            this.btnPainelTarefas.Name = "btnPainelTarefas";
            this.btnPainelTarefas.UseVisualStyleBackColor = true;
            this.btnPainelTarefas.Click += new System.EventHandler(this.btnClickTarefas);
            // 
            // btnPainel
            // 
            resources.ApplyResources(this.btnPainel, "btnPainel");
            this.btnPainel.FlatAppearance.BorderSize = 0;
            this.btnPainel.ForeColor = System.Drawing.Color.White;
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.UseVisualStyleBackColor = true;
            this.btnPainel.Click += new System.EventHandler(this.btnClickPainel);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.CloseForm);
            // 
            // CertwebSystemTray
            // 
            resources.ApplyResources(this.CertwebSystemTray, "CertwebSystemTray");
            this.CertwebSystemTray.ContextMenuStrip = this.MenuSystemTray;
            // 
            // MenuSystemTray
            // 
            resources.ApplyResources(this.MenuSystemTray, "MenuSystemTray");
            this.MenuSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.MenuSystemTray.Name = "MenuSystemTray";
            // 
            // executarToolStripMenuItem
            // 
            resources.ApplyResources(this.executarToolStripMenuItem, "executarToolStripMenuItem");
            this.executarToolStripMenuItem.Name = "executarToolStripMenuItem";
            this.executarToolStripMenuItem.Click += new System.EventHandler(this.ExecutarTarefas);
            // 
            // fecharToolStripMenuItem
            // 
            resources.ApplyResources(this.fecharToolStripMenuItem, "fecharToolStripMenuItem");
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.CloseForm);
            // 
            // pnTarefas
            // 
            resources.ApplyResources(this.pnTarefas, "pnTarefas");
            this.pnTarefas.BackColor = System.Drawing.Color.White;
            this.pnTarefas.Name = "pnTarefas";
            // 
            // pnLinks
            // 
            resources.ApplyResources(this.pnLinks, "pnLinks");
            this.pnLinks.BackColor = System.Drawing.Color.White;
            this.pnLinks.Name = "pnLinks";
            // 
            // pnPainel
            // 
            resources.ApplyResources(this.pnPainel, "pnPainel");
            this.pnPainel.BackColor = System.Drawing.Color.White;
            this.pnPainel.Name = "pnPainel";
            // 
            // pnSobre
            // 
            resources.ApplyResources(this.pnSobre, "pnSobre");
            this.pnSobre.BackColor = System.Drawing.Color.White;
            this.pnSobre.Name = "pnSobre";
            // 
            // TelaInicial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnTarefas);
            this.Controls.Add(this.pnLinks);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnDragDrop);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnPainel);
            this.Controls.Add(this.pnSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MenuSystemTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDragDrop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPainel;
        private System.Windows.Forms.Button btnPainelTarefas;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnClose;
        private Painel pnPainel;
        private Sobre pnSobre;
        private System.Windows.Forms.Panel pnIndicador;
        private Links pnLinks;
        private Tarefas pnTarefas;
        private System.Windows.Forms.ContextMenuStrip MenuSystemTray;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executarToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon CertwebSystemTray;
    }
}

