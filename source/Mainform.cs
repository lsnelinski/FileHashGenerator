using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FileHashGenerator
{
  public partial class Mainform : Form
  {
    public Mainform()
    {
      InitializeComponent();
    }

    private void Generate_Click(object sender, EventArgs e)
    {
      try
      {
        var fileHashGenerator = new FileHashGenerator();
        fileHashGenerator.GenerateHashes();

        var result = MessageBox.Show("The hashes have been successfully created " +
          "and the program will now be closed.\r\nShould the log file be opened in the editor?",
          "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
          Process.Start("notepad.exe", fileHashGenerator.LogFileLocation);
        }
      }
      catch (Exception exception)
      {
        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        Close();
      }
    }
  }
}
