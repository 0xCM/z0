//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiKey
    {
        readonly ulong Lo;

        readonly ulong Hi;

        [MethodImpl(Inline)]
        internal ApiKey(ApiKeyId id, PartId part, ApiArtifactKey host, ApiArtifactKey method)
        {
            Lo = (ulong)id |((ulong)host  << 16) | ((ulong)part << 32);
            Hi = (ulong)method;
        }
    }
}