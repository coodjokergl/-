namespace 运营巡检规则管理工具.用户界面.基础组件.窗体
{
    partial class BaseForm
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
            if (disposing && ( components != null ))
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
            this.Hidepanel = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonExist = new System.Windows.Forms.Button();
            this.Hidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hidepanel
            // 
            this.Hidepanel.Controls.Add(this.buttonOk);
            this.Hidepanel.Controls.Add(this.buttonExist);
            this.Hidepanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Hidepanel.Location = new System.Drawing.Point(0, 403);
            this.Hidepanel.Name = "Hidepanel";
            this.Hidepanel.Size = new System.Drawing.Size(800, 47);
            this.Hidepanel.TabIndex = 0;
            this.Hidepanel.Visible = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(641, 12);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonExist
            // 
            this.buttonExist.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExist.Location = new System.Drawing.Point(722, 12);
            this.buttonExist.Name = "buttonExist";
            this.buttonExist.Size = new System.Drawing.Size(75, 23);
            this.buttonExist.TabIndex = 0;
            this.buttonExist.Text = "退出";
            this.buttonExist.UseVisualStyleBackColor = true;
            this.buttonExist.Click += new System.EventHandler(this.buttonExist_Click);
            // 
            // BaseForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExist;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hidepanel);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Hidepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Hidepanel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonExist;
    }
}