
namespace App
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
      this.Generate_bt = new System.Windows.Forms.Button();
      this.Algorithm_lb = new System.Windows.Forms.Label();
      this.Algorithm_cb = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // Generate_bt
      // 
      this.Generate_bt.Location = new System.Drawing.Point(12, 41);
      this.Generate_bt.Name = "Generate_bt";
      this.Generate_bt.Size = new System.Drawing.Size(223, 50);
      this.Generate_bt.TabIndex = 0;
      this.Generate_bt.Text = "Compute hashes";
      this.Generate_bt.UseVisualStyleBackColor = true;
      this.Generate_bt.Click += new System.EventHandler(this.Generate_Click);
      // 
      // Algorithm_lb
      // 
      this.Algorithm_lb.AutoSize = true;
      this.Algorithm_lb.Location = new System.Drawing.Point(12, 15);
      this.Algorithm_lb.Name = "Algorithm_lb";
      this.Algorithm_lb.Size = new System.Drawing.Size(64, 15);
      this.Algorithm_lb.TabIndex = 1;
      this.Algorithm_lb.Text = "Algorithm:";
      // 
      // Algorithm_cb
      // 
      this.Algorithm_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.Algorithm_cb.FormattingEnabled = true;
      this.Algorithm_cb.Location = new System.Drawing.Point(82, 12);
      this.Algorithm_cb.Name = "Algorithm_cb";
      this.Algorithm_cb.Size = new System.Drawing.Size(153, 23);
      this.Algorithm_cb.TabIndex = 2;
      // 
      // Mainform
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(247, 103);
      this.Controls.Add(this.Algorithm_cb);
      this.Controls.Add(this.Algorithm_lb);
      this.Controls.Add(this.Generate_bt);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Mainform";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FileHashGenerator";
      this.Load += new System.EventHandler(this.Mainform_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Generate_bt;
    private System.Windows.Forms.Label Algorithm_lb;
    private System.Windows.Forms.ComboBox Algorithm_cb;
  }
}

