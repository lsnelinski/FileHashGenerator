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
          bat "dotnet ${SONARSCANNER}\\SonarScanner.MSBuild.dll begin /k:\"FileHashGenerator\""
          bat "dotnet build"
          bat "dotnet ${SONARSCANNER}\\SonarScanner.MSBuild.dll end"
        }
      }
    }
  }
}
