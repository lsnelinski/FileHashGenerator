using System;
using System.Diagnostics;
using System.Windows.Forms;
using HashGenerator;

namespace App
{
  public partial class Mainform : Form
  {
    public Mainform()
    {
      InitializeComponent();
    }

    private void Generate_Click(object sender, EventArgs e)
    {
      var selectedAlgorithm = (Algorithms)Algorithm_cb.SelectedItem;

      try
      {
        var fileHashGenerator = new Generator();
        fileHashGenerator.GenerateHashes(selectedAlgorithm);

        var dialogResult = MessageBox.Show("The hashes have been successfully created " +
          "and the program will now be closed.\r\nShould the log file be opened in the editor?",
          "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dialogResult == DialogResult.Yes)
        {
          var process = new Process();
          process.StartInfo.FileName = @"C:\windows\system32\notepad.exe";
          process.StartInfo.Arguments = fileHashGenerator.LogFileLocation;
          process.Start();
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

    private void Mainform_Load(object sender, EventArgs e)
    {
      var algorithms = Enum.GetValues<Algorithms>();
      Algorithm_cb.DataSource = algorithms;
    }
  }
}
