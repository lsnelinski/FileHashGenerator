pipeline {
  agent { label 'windows' }

  environment {
    SONARSCANNER = tool 'SonarScannerMSBuild'
  }

  options {
    skipDefaultCheckout(true)
  }

  stages {
    stage('Cleanup Workspace') {
      steps {
        cleanWs()
      }
    }

    stage('Checkout GitHub') {
      steps {
        checkout scm
      }
    }

    stage('Build & Execute SonarQube') {
      steps {
        withSonarQubeEnv('SonarQube') {
          bat 'nuget restore'
          bat "${SONARSCANNER}\\SonarQube.Scanner.MSBuild.exe begin /k:FileHashGenerator"
          bat 'MSBuild.exe /t:Rebuild'
          bat "${SONARSCANNER}\\SonarQube.Scanner.MSBuild.exe end"
        }
      }
    }
  }
}
