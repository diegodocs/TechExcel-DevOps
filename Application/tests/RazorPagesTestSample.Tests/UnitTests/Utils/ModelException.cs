using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RazorPagesTestSample.Tests.UnitTests.Utils
{
    [Serializable]
    public class ModelException : Exception
    {
        public ModelException(string message, IEnumerable<ValidationResult> errors) : base(message)
        {
            Errors = errors;
        }

        public ModelException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ModelException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public IEnumerable<ValidationResult> Errors { get; protected set; }
    }
}