//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct ApiSummaryInfo
    {
        public const string TableId = "z0.api";

        public MemoryAddress Address;

        public ApiMetadataUri Uri;

        public GenericState Genericity;

        public ClrSig Sig;

        public MethodMetadata Metadata;
    }
}