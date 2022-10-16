# FileHashGenerator

![GitHub](https://img.shields.io/github/license/lsnelinski/FileHashGenerator)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=lsnelinski_FileHashGenerator&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=lsnelinski_FileHashGenerator)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=lsnelinski_FileHashGenerator&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=lsnelinski_FileHashGenerator)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=lsnelinski_FileHashGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=lsnelinski_FileHashGenerator)

The FileHashGenerator is a small tool which generates a SHA1 or SHA256 hash of all files which are stored in the same directory as the app.

## How the tool works

The tool was created with (oldschool) WinForms. If you click on the button, a SHA1 or SHA256 hash of every file in the directory of this app will be created. Just copy the program into the directory of your choice. Then a folder named "fileHashGenerator_Log" will be created in this directory. In this folder you will find the "hashes.log" file.
