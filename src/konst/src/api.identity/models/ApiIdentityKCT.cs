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

    public readonly struct ApiIdentity<K,C,T>
        where K : unmanaged
        where C : unmanaged
        where T : struct
    {
        public readonly ApiIdentity<K,T> Identity;

        public readonly C Classifier;

        [MethodImpl(Inline)]
        public ApiIdentity(PartId part, ClrArtifactKey host, K apikey, T id, C @class)
        {
            Identity = new ApiIdentity<K,T>(part, host, apikey, id);
            Classifier = @class;
        }
    }
}