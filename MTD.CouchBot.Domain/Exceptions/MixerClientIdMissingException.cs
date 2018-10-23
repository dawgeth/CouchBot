﻿using System;
using System.Runtime.Serialization;

namespace MTD.CouchBot.Domain.Exceptions
{
    public class MixerClientIdMissingException : Exception
    {
        public MixerClientIdMissingException()
        {
        }

        public MixerClientIdMissingException(string message) : base(message)
        {
        }

        public MixerClientIdMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MixerClientIdMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
