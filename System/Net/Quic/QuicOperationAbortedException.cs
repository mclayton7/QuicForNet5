// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.Quic
{
    public class QuicOperationAbortedException : QuicException
    {
        internal QuicOperationAbortedException()
            : base($"Operation aborted.")
        {
        }

        public QuicOperationAbortedException(string message) : base(message)
        {
        }
    }
}
