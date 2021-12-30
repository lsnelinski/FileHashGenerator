using System.IO;
using System;
using System.Security.Cryptography;

namespace FileHashGenerator
{
  class FileHashGenerator
  {
    #region Variables
    private const string LOG_DIRECTORY = "fileHashGenerator_Log";
    private const string LOG_FILENAME = "hashes.log";
    private string _currentAppDirectory;

    #endregion

    #region Properties
    /// <summary>
    ///   Full path of the log folder.
    /// </summary>
    public string LogFolderLocation
    {
      get { return $@"{_currentAppDirectory}\{LOG_DIRECTORY}"; }
    }

    /// <summary>
    ///   Full path of the log file.
    /// </summary>
    public string LogFileLocation
    {
      get { return $@"{_currentAppDirectory}\{LOG_DIRECTORY}\{LOG_FILENAME}"; }
    }

    #endregion

    #region Constructor
    /// <summary>
    ///   The constructor reads the current app path and creates the hasher enviroment.
    /// </summary>
    public FileHashGenerator()
    {
      _currentAppDirectory = Directory.GetCurrentDirectory();
      CreateHasherEnviroment();
    }

    #endregion

    #region Methods
    /// <summary>
    ///   Creates the directory and a empty logfile in it.
    /// </summary>
    private void CreateHasherEnviroment()
    {
      if (!Directory.Exists(LogFolderLocation))
      {
        Directory.CreateDirectory(LogFolderLocation);
        File.Create(LogFileLocation).Close();
      }
      else
      {
        if (File.Exists(LogFileLocation))
        {
          File.Delete(LogFileLocation);
        }

        File.Create(LogFileLocation).Close();
      }
    }

    /// <summary>
    ///    Generates the file hashes in the current app directory.
    /// </summary>
    public void GenerateHashes()
    {
      using (var streamWriter = File.AppendText(LogFileLocation))
      using (var cryptoProvider = new SHA1CryptoServiceProvider())
      {
        DirectoryInfo directoryInfo = new DirectoryInfo(_currentAppDirectory);
        FileInfo[] files = directoryInfo.GetFiles();

        for (int i = 0; i < files.Length; i++)
        {
          var currentFile = files[i].Name;
          byte[] buffer = File.ReadAllBytes(currentFile);
          string hash = BitConverter.ToString(cryptoProvider.ComputeHash(buffer))
            .Replace("-", "")
            .ToUpper();

          streamWriter.WriteLine($@"Hash: {hash} --> File: {currentFile}");
        }
      }
    }

    #endregion
  }
}
