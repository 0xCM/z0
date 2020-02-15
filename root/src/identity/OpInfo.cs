//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static RootShare;

    public readonly struct OpInfo
    {        
        [MethodImpl(Inline)]
        public static OpInfo Define(OpUri uri, string sig)
            => new OpInfo(uri,sig);

        [MethodImpl(Inline)]
        OpInfo(OpUri uri, string sig)
        {
            this.Uri = uri;
            this.Signature = sig;
        }

        public readonly OpUri Uri;

        public readonly string Signature;

        public ApiHostPath Host
            => Uri.HostPath;
        
        public OpIdentity Id
            => Uri.OpId;        
    }
}