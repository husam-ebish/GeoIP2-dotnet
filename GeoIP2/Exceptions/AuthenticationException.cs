﻿#region

using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

#endregion

namespace MaxMind.GeoIP2.Exceptions
{
    /// <summary>
    ///     This exception is thrown when there is an authentication error.
    /// </summary>
    [Serializable]
    public class AuthenticationException : GeoIP2Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AuthenticationException" /> class.
        /// </summary>
        /// <param name="message">A message explaining the cause of the error.</param>
        public AuthenticationException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="AuthenticationException" /> class.
        /// </summary>
        /// <param name="message">A message explaining the cause of the error.</param>
        /// <param name="innerException">The inner exception.</param>
        public AuthenticationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Constructor for deserialization.
        /// </summary>
        /// <param name="info">The SerializationInfo with data.</param>
        /// <param name="context">The source for this deserialization.</param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        protected AuthenticationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}