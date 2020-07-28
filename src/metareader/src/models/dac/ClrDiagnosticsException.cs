//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;
    using System.Runtime.Serialization;

    using static ClrDataModel;

    /// <summary>
    /// Exception kind
    /// </summary>
    public enum ClrDiagnosticsExceptionKind
    {
        /// <summary>
        /// Unknown error occured.
        /// </summary>
        Unknown,

        /// <summary>
        /// Dump file is corrupted or has an unknown format.
        /// </summary>
        CorruptedFileOrUnknownFormat,

        /// <summary>
        /// The caller attempted to re-use an object after calling <see cref="ClrRuntime.FlushCachedData"/>.  See the
        /// documentation for <see cref="ClrRuntime.FlushCachedData"/> for more details.
        /// </summary>
        RevisionMismatch,

        /// <summary>
        /// Something unexpected went wrong with the debugger we used to attach to the process or load the crash dump.
        /// </summary>
        DebuggerError,

        /// <summary>
        /// An error occurred while processing the given crash dump.
        /// </summary>
        CrashDumpError,

        /// <summary>
        /// Something unexpected went wrong when requesting data from the target process.
        /// </summary>
        DataRequestError,

        /// <summary>
        /// Hit an unexpected (non-recoverable) DAC error.
        /// </summary>
        DacError,

        /// <summary>
        /// The dll of the specified runtime (<i>mscorwks.dll</i> or <i>clr.dll</i>) is loaded into the process, but
        /// has not actually been initialized and thus cannot be debugged.
        /// </summary>
        RuntimeUninitialized
    }

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