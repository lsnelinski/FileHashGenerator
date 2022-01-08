:: Variables
set pathToSolution="%cd%\FileHashGenerator.sln"
set pathToMSBuild="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin"

:: Restore NuGet
nuget.exe restore

:: Build Solution
cd /d %pathToMSBuild%
MSBuild.exe %pathToSolution% /p:configuration=debug

pause
