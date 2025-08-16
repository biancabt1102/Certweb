namespace Certweb
{
    partial class Tarefas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarefas));
            this.pnFlowLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pnFlowLinks
            // 
            resources.ApplyResources(this.pnFlowLinks, "pnFlowLinks");
            this.pnFlowLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFlowLinks.Name = "pnFlowLinks";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnExecutar
            // 
            resources.ApplyResources(this.btnExecutar, "btnExecutar");
            this.btnExecutar.FlatAppearance.BorderSize = 0;
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.Name = "ProgressBar";
            // 
            // Tarefas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.pnFlowLinks);
            this.Controls.Add(this.label1);
            this.Name = "Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnFlowLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}
