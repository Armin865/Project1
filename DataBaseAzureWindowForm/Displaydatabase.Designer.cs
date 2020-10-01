namespace DataBaseWindowForm
{
    partial class Displaydatabase
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
            this.button1 = new System.Windows.Forms.Button();
            this.PeopleFoundList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 135);
            this.button1.TabIndex = 0;
            this.button1.Text = "Display Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PeopleFoundList
            // 
            this.PeopleFoundList.FormattingEnabled = true;
            this.PeopleFoundList.ItemHeight = 20;
            this.PeopleFoundList.Location = new System.Drawing.Point(315, 208);
            this.PeopleFoundList.Name = "PeopleFoundList";
            this.PeopleFoundList.Size = new System.Drawing.Size(853, 464);
            this.PeopleFoundList.TabIndex = 1;
            this.PeopleFoundList.SelectedIndexChanged += new System.EventHandler(this.PeopleFoundList_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Displaydatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 757);
            this.Controls.Add(this.PeopleFoundList);
            this.Controls.Add(this.button1);
            this.Name = "Displaydatabase";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Displaydatabase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox PeopleFoundList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}