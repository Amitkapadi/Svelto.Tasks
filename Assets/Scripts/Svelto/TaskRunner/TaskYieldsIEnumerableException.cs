﻿using System;
using System.Runtime.Serialization;

namespace Svelto.Tasks
{
    [Serializable]
    internal class TaskYieldsIEnumerableException : Exception
    {
        public TaskYieldsIEnumerableException()
        {
        }

        public TaskYieldsIEnumerableException(string message) : base(message)
        {
        }

        public TaskYieldsIEnumerableException(string message, Exception innerException) : base(message, innerException)
        {
        }
#if !UNITY_WSA_10_0
        protected TaskYieldsIEnumerableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}