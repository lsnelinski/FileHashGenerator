using Xunit;

namespace HashGenerator.Tests
{
  public class GeneratorTests
  {
    private readonly Generator _generator;

    public GeneratorTests()
    {
      _generator = new Generator();
    }

    [Fact]
    public void LogFolderLocation_ShouldReturnCorrectLogFolderLocation()
    {
      string actualLogFolderLocation = _generator.LogFolderLocation;
      string expectedLogFolderLocation = Path.Combine(Directory.GetCurrentDirectory(), "fileHashGenerator_Log");

      Assert.Equal(expectedLogFolderLocation, actualLogFolderLocation);
    }

    [Fact]
    public void LogFileLocation_ShouldReturnCorrectLogFileNameAndLocation()
    {
      string actualLogFileLocation = _generator.LogFileLocation;
      string expectedLogFileLocation = Path.Combine(Directory.GetCurrentDirectory(), "fileHashGenerator_Log", "hashes.log");

      Assert.Equal(expectedLogFileLocation, actualLogFileLocation);
    }
  }
}
