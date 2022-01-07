pipeline {
  agent "windows"

  options {
    skipDefaultCheckout(true)
  }

  stages {
    stage('Build') {
      steps {
        cleanWS()
        checkout scm
        bat '.\\buildCI.bat'
      }
    }
  }
}
