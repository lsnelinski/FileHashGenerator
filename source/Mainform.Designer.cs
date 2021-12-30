
namespace FileHashGenerator
{
  partial class Mainform
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.Generate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Generate
      // 
      this.Generate.Location = new System.Drawing.Point(12, 12);
      this.Generate.Name = "Generate";
      this.Generate.Size = new System.Drawing.Size(223, 50);
      this.Generate.TabIndex = 0;
      this.Generate.Text = "Generate SHA1 Hashes";
      this.Generate.UseVisualStyleBackColor = true;
      this.Generate.Click += new System.EventHandler(this.Generate_Click);
      // 
      // Mainform
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(247, 74);
      this.Controls.Add(this.Generate);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Mainform";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FileHashGenerator";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button Generate;
  }
}

