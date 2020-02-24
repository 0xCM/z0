//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    /// <summary>
    /// Identifies and describes a hosted operation
    /// </summary>
    public readonly struct OpDescriptor
    {        
        /// <summary>
        /// Defines an operation descriptor
        /// </summary>
        /// <param name="uri">The operation uri</param>
        /// <param name="sig">The operation signature</param>
        [MethodImpl(Inline)]
        public static OpDescriptor Define(OpUri uri, string sig)
            => new OpDescriptor(uri,sig);

        [MethodImpl(Inline)]
        OpDescriptor(OpUri uri, string sig)
        {
            this.Uri = uri;
            this.Signature = sig;
        }

        /// <summary>
        /// The operation uri identifies it uniquely among all operaions in all hosts
        /// </summary>
        public readonly OpUri Uri;

        /// <summary>
        /// The signature of the defining method, formatted for display/legibility
        /// </summary>
        public readonly string Signature;

        /// <summary>
        /// The defining host
        /// </summary>
        public ApiHostPath Host
            => Uri.HostPath;
        
        /// <summary>
        /// The operation id, unique with respect to all operations implemented by the defining host
        /// </summary>
        public OpIdentity Id
            => Uri.OpId;        
    }
}