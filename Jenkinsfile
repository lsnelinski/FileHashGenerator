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

    stage('Build & Execute SonarQube analysis') {
      steps {
        withSonarQubeEnv('SonarQube') {
          bat 'nuget restore'
          bat "${SONARSCANNER}\\SonarScanner.MSBuild.exe begin /k:FileHashGenerator"
          bat 'MSBuild.exe /t:Rebuild'
          bat "${SONARSCANNER}\\SonarScanner.MSBuild.exe end"
        }
      }
    }
  }
}
