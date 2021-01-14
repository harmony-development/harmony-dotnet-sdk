
Server {
  Host           = "0.0.0.0"
  Port           = 2289
  PrivateKeyPath = "harmony-key.pem"
  PublicKeyPath  = "harmony-key.pub"
  StorageBackend = "PureFlatfile"
  SnowflakeStart = 0
  UseCORS        = true

  Policies {
    EnablePasswordResetForm = false

    Avatar {
      Width   = 256
      Height  = 256
      Quality = 50
      Crop    = true
    }

    Username {
      MinLength = 2
      MaxLength = 32
    }

    Password {
      MinLength  = 5
      MaxLength  = 256
      MinLower   = 1
      MinUpper   = 1
      MinNumbers = 1
      MinSymbols = 0
    }

    Attachments {
      MaximumCount = 10
    }

    Debug {
      LogErrors                  = true
      LogRequests                = true
      RespondWithErrors          = true
      ResponseErrorsIncludeTrace = true
      VerboseStreamHandling      = true
    }

    Sessions {
      Duration = 172800000000000
    }

    Caches {
      Owner       = 5096
      Sessions    = 5096
      LinkEmbeds  = 65536
      InstantView = 65536
    }

    APIs {

      Messages {
        MaximumGetAmount = 50
      }
    }

    Federation {
      NonceLength                       = 32
      GuildLeaveNotificationQueueLength = 64
    }
  }
}

Database {
  Host     = "postgres"
  Username = "postgres"
  Password = "postgres"
  Port     = 5432
  SSL      = false
  Name     = "postgres"
}

Flatfile {
  MediaPath = "flatfile"
}

Sentry {
  DSN               = ""
  AttachStacktraces = true
  Enabled           = false
}
