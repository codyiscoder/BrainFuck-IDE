namespace BrainFuckIDE
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox codeEditor;
        private System.Windows.Forms.RichTextBox outputBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.codeEditor = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            this.codeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.codeEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeEditor.Font = new System.Drawing.Font("Consolas", 12F);
            this.codeEditor.ForeColor = System.Drawing.Color.White;
            this.codeEditor.Location = new System.Drawing.Point(20, 20);
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Size = new System.Drawing.Size(600, 500);
            this.codeEditor.TabIndex = 0;
            this.codeEditor.Text = "";
            this.codeEditor.TextChanged += new System.EventHandler(this.CodeEditor_TextChanged);
            this.codeEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                         | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.BackColor = System.Drawing.Color.Black;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.outputBox.ForeColor = System.Drawing.Color.Lime;
            this.outputBox.Location = new System.Drawing.Point(640, 20);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(330, 500);
            this.outputBox.TabIndex = 1;
            this.outputBox.Text = "";
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                        | System.Windows.Forms.AnchorStyles.Right))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(988, 540);
            this.Controls.Add(this.codeEditor);
            this.Controls.Add(this.outputBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BrainFuck IDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
    }
}