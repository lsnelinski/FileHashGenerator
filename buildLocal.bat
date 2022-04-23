:: Variables
set pathToSolution="%cd%\source\FileHashGenerator.sln"
set pathToMSBuild="C:\Program Files\Microsoft Visual Studio\2022\Community\Msbuild\Current\Bin\amd64"

:: Restore NuGet
nuget.exe restore %pathToSolution%

:: Build Solution
cd /d %pathToMSBuild%
MSBuild.exe %pathToSolution% /p:configuration=debug

pause
