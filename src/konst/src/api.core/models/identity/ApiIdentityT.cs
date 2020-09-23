//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    public readonly struct ApiIdentity<K,T>
        where K : unmanaged, Enum
        where T : struct
    {
        public readonly PartId Part;

        public readonly ClrArtifactKey HostId;

        public readonly K ApiKey;

        public readonly T Identifier;

        [MethodImpl(Inline)]
        public ApiIdentity(PartId part, ClrArtifactKey host, K apikey, T id)
        {
            Part = part;
            HostId = host;
            ApiKey = apikey;
            Identifier = id;
        }
    }

    public readonly struct ApiIdentity<K,C,T>
        where K : unmanaged, Enum
        where C : unmanaged
        where T : struct
    {
        public readonly ApiIdentity<K,T> Identity;

        public readonly C Classifier;

        [MethodImpl(Inline)]
        public ApiIdentity(PartId part, ClrArtifactKey host,  K apikey, T id, C @class)
        {
            Identity = new ApiIdentity<K,T>(part, host, apikey,id);
            Classifier = @class;
        }
    }
}