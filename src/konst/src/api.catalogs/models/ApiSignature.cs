//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;
    using static ApiSignatures;

    public readonly struct ApiSignature : IApiSignature<ApiSignature>
    {
        const byte PartCount = 8;

        readonly Vector256<uint> Data;

        public StringRef Identifier {get;}

        [MethodImpl(Inline)]
        internal ApiSignature(string identifier, Vector256<uint> aspects)
        {
            Data = aspects;
            Identifier = identifier;
        }

        public CliArtifactKey TargetKey
        {
            [MethodImpl(Inline)]
            get => vcell(Data,PartCount - 1);
        }

        public Cell256 Aspects
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}