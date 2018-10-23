﻿using System;
using System.Runtime.Serialization;

namespace MTD.CouchBot.Domain.Exceptions
{
    public class YouTubeApiKeyMissingException : Exception
    {
        public YouTubeApiKeyMissingException()
        {
        }

        public YouTubeApiKeyMissingException(string message) : base(message)
        {
        }

        public YouTubeApiKeyMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected YouTubeApiKeyMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
