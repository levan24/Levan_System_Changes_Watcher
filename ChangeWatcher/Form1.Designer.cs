namespace ChangeWatcher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fswMain = new System.IO.FileSystemWatcher();
            this.tbEvents = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fswMain)).BeginInit();
            this.SuspendLayout();
            // 
            // fswMain
            // 
            this.fswMain.EnableRaisingEvents = true;
            this.fswMain.IncludeSubdirectories = true;
            this.fswMain.NotifyFilter = ((System.IO.NotifyFilters)((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.LastWrite) 
            | System.IO.NotifyFilters.LastAccess)));
            this.fswMain.Path = "C:/";
            this.fswMain.SynchronizingObject = this;
            this.fswMain.Changed += new System.IO.FileSystemEventHandler(this.fswMain_Changed);
            this.fswMain.Created += new System.IO.FileSystemEventHandler(this.fswMain_Created);
            this.fswMain.Deleted += new System.IO.FileSystemEventHandler(this.fswMain_Deleted);
            this.fswMain.Renamed += new System.IO.RenamedEventHandler(this.fswMain_Renamed);
            // 
            // tbEvents
            // 
            this.tbEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEvents.Location = new System.Drawing.Point(12, 12);
            this.tbEvents.Multiline = true;
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.ReadOnly = true;
            this.tbEvents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbEvents.Size = new System.Drawing.Size(776, 371);
            this.tbEvents.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Log";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(713, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear Log";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(12, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Enter File Name";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Changed Log Information";
            ((System.ComponentModel.ISupportInitialize)(this.fswMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fswMain;
        private System.Windows.Forms.TextBox tbEvents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

