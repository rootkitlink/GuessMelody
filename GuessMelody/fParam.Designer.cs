namespace GuessMelody
{
    partial class fParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParam));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chbxFolders = new System.Windows.Forms.CheckBox();
            this.btnOkParam = new System.Windows.Forms.Button();
            this.btnExitParam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(603, 238);
            this.listBox1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(13, 244);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(318, 34);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить из папки";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(13, 279);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(318, 34);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить список";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // chbxFolders
            // 
            this.chbxFolders.AutoSize = true;
            this.chbxFolders.Checked = true;
            this.chbxFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxFolders.Location = new System.Drawing.Point(427, 249);
            this.chbxFolders.Name = "chbxFolders";
            this.chbxFolders.Size = new System.Drawing.Size(188, 17);
            this.chbxFolders.TabIndex = 3;
            this.chbxFolders.Text = "Обрабатывать вложеные папки";
            this.chbxFolders.UseVisualStyleBackColor = true;
            // 
            // btnOkParam
            // 
            this.btnOkParam.Location = new System.Drawing.Point(368, 302);
            this.btnOkParam.Name = "btnOkParam";
            this.btnOkParam.Size = new System.Drawing.Size(106, 33);
            this.btnOkParam.TabIndex = 4;
            this.btnOkParam.Text = "OK";
            this.btnOkParam.UseVisualStyleBackColor = true;
            this.btnOkParam.Click += new System.EventHandler(this.btnOkParam_Click);
            // 
            // btnExitParam
            // 
            this.btnExitParam.Location = new System.Drawing.Point(492, 302);
            this.btnExitParam.Name = "btnExitParam";
            this.btnExitParam.Size = new System.Drawing.Size(106, 33);
            this.btnExitParam.TabIndex = 5;
            this.btnExitParam.Text = "Выход";
            this.btnExitParam.UseVisualStyleBackColor = true;
            this.btnExitParam.Click += new System.EventHandler(this.btnExitParam_Click);
            // 
            // fParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 337);
            this.Controls.Add(this.btnExitParam);
            this.Controls.Add(this.btnOkParam);
            this.Controls.Add(this.chbxFolders);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fParam";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chbxFolders;
        private System.Windows.Forms.Button btnOkParam;
        private System.Windows.Forms.Button btnExitParam;
    }
}