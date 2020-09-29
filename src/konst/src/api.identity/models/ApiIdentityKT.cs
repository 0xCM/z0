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

    public readonly struct ApiIdentity<K,T>
        where K : unmanaged
        where T : struct
    {
        public readonly PartId Part;

        public readonly ClrArtifactKey HostId;

        public readonly T Identifier;

        public readonly K ApiKey;

        [MethodImpl(Inline)]
        public ApiIdentity(PartId part, ClrArtifactKey host, K apikey, T id)
        {
            Part = part;
            HostId = host;
            ApiKey = apikey;
            Identifier = id;
        }
    }
}