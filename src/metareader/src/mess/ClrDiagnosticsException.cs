//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.Serialization;

    using Z0.MS;
    
    /// <summary>
    /// Exception thrown by Microsoft.Diagnostics.Runtime unless there is a more appropriate
    /// exception subclass.
    /// </summary>
    [Serializable]
    public class ClrDiagnosticsException : Exception
    {
        internal ClrDiagnosticsException(string message, ClrDiagnosticsExceptionKind kind = ClrDiagnosticsExceptionKind.Unknown, int hr = -2146233088)
            : base(message)
        {
            Kind = kind;
            HResult = hr;
        }

        /// <summary>
        /// Gets exception kind.
        /// </summary>
        public ClrDiagnosticsExceptionKind Kind { get; }

        protected ClrDiagnosticsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            if (info is null)
                throw new ArgumentNullException(nameof(info));

            Kind = (ClrDiagnosticsExceptionKind)info.GetValue(nameof(Kind), typeof(ClrDiagnosticsExceptionKind))!;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info is null)
                throw new ArgumentNullException(nameof(info));

            info.AddValue(nameof(Kind), Kind, typeof(ClrDiagnosticsExceptionKind));
            base.GetObjectData(info, context);
        }
    }
}