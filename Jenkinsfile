pipeline {
  agent { label 'windows' }

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

    stage('Build') {
      steps {
        bat '.\\buildCI.bat'
      }
    }
  }
}
