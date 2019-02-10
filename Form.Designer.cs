namespace Micropix
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.snipBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.autosaveCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerCombobox = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // snipBtn
            // 
            this.snipBtn.Location = new System.Drawing.Point(12, 12);
            this.snipBtn.Name = "snipBtn";
            this.snipBtn.Size = new System.Drawing.Size(57, 45);
            this.snipBtn.TabIndex = 0;
            this.snipBtn.UseVisualStyleBackColor = true;
            this.snipBtn.Click += new System.EventHandler(this.snipBtn_ClickAsync);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.notificationLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 68);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(311, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Micropix.Properties.Resources.favicon1;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeformToolStripMenuItem,
            this.fullScreenToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.styleToolStripMenuItem.Text = "Options";
            // 
            // freeformToolStripMenuItem
            // 
            this.freeformToolStripMenuItem.Name = "freeformToolStripMenuItem";
            this.freeformToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.freeformToolStripMenuItem.Text = "Freeform";
            this.freeformToolStripMenuItem.Click += new System.EventHandler(this.freeformToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fullScreenToolStripMenuItem.Text = "Full screen ";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // notificationLabel
            // 
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(95, 17);
            this.notificationLabel.Text = "Micropix loaded!";
            // 
            // autosaveCheckBox
            // 
            this.autosaveCheckBox.AutoSize = true;
            this.autosaveCheckBox.Location = new System.Drawing.Point(170, 40);
            this.autosaveCheckBox.Name = "autosaveCheckBox";
            this.autosaveCheckBox.Size = new System.Drawing.Size(129, 17);
            this.autosaveCheckBox.TabIndex = 2;
            this.autosaveCheckBox.Text = "Autosave to clipboard";
            this.autosaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // timerCombobox
            // 
            this.timerCombobox.FormattingEnabled = true;
            this.timerCombobox.Items.AddRange(new object[] {
            "1 second delay",
            "2 seconds delay",
            "3 seconds delay",
            "4 seconds delay",
            "5 seconds delay"});
            this.timerCombobox.Location = new System.Drawing.Point(170, 13);
            this.timerCombobox.Name = "timerCombobox";
            this.timerCombobox.Size = new System.Drawing.Size(121, 21);
            this.timerCombobox.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 90);
            this.Controls.Add(this.timerCombobox);
            this.Controls.Add(this.autosaveCheckBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.snipBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Micropix";
            this.Load += new System.EventHandler(this.Form_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button snipBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel notificationLabel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.CheckBox autosaveCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox timerCombobox;
    }
}

