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
    using static ArtifactModel;

    public readonly struct ArtifactRef
    {
        public readonly ArtifactIdentifier Id;

        [MethodImpl(Inline)]
        public ArtifactRef(Type t)
        {
            Id = t.MetadataToken;
        }

        [MethodImpl(Inline)]
        public ArtifactRef(ArtifactIdentifier src)
        {
            Id = src;
        }
    }
}