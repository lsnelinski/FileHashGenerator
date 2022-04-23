using System;
using System.IO;
using System.Security.Cryptography;

namespace FileHashGenerator
{
  class FileHashGenerator
  {
    #region Variables
    private const string LOG_DIRECTORY = "fileHashGenerator_Log";
    private const string LOG_FILENAME = "hashes.log";
    readonly string _currentAppDirectory;

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
    ///   Generates the file hashes in the current app directory.
    /// </summary>
    /// <param name="algorithm">An algorithm corresponding to the <seealso cref="AlgorithmEnum">AlgorithmEnum</seealso>.</param>
    /// <exception cref="Exception">Throws an exception if the algorithm is unknown.</exception>
    public void GenerateHashes(AlgorithmEnum algorithm)
    {
      HashAlgorithm cryptoProvider;

      switch (algorithm)
      {
        case AlgorithmEnum.SHA1:
          cryptoProvider = new SHA1CryptoServiceProvider();
          break;
        case AlgorithmEnum.SHA256:
          cryptoProvider = SHA256.Create();
          break;
        default:
          cryptoProvider = null;
          break;
      }

      if (cryptoProvider != null)
      {
        using (var streamWriter = File.AppendText(LogFileLocation))
        {
          DirectoryInfo directoryInfo = new DirectoryInfo(_currentAppDirectory);
          FileInfo[] files = directoryInfo.GetFiles();

          for (int i = 0; i < files.Length; i++)
          {
            var currentFile = files[i].Name;
            byte[] buffer = File.ReadAllBytes(currentFile);
            string hash = BitConverter.ToString(cryptoProvider.ComputeHash(buffer))
              .Replace("-", "")
              .ToLower();

            streamWriter.WriteLine($@"{algorithm}-Hash: {hash} --> File: {currentFile}");
          }
        }
      }
      else
      {
        throw new ArgumentException($@"The algorithm '{algorithm}' is unknown or has not been implemented yet!");
      }

      cryptoProvider.Dispose();
    }

    #endregion
  }
}
