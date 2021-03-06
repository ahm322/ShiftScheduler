﻿using System;
using System.Net;
using System.Runtime.Serialization;
using Onyx.ShiftScheduler.Core.Interfaces;

namespace Onyx.ShiftScheduler.Core.Exceptions
{
    [Serializable]
    public class ApplicationNotFoundException : ApplicationException, IException
    {
        public ApplicationNotFoundException()
        {
            StatusCode = HttpStatusCode.NotFound;
        }

        public ApplicationNotFoundException(string message) : base(message)
        {
            Error = message;
        }

        public ApplicationNotFoundException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {
        }

        public ApplicationNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
            Error = message;
        }

        public HttpStatusCode StatusCode { get; set; }

        public string Error { get; set; }
    }
}