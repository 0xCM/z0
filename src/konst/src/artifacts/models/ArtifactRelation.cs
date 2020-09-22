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

    /// <summary>
    /// Defines a directed association from one artifact to another
    /// </summary>
    public readonly struct ArtifactRelation
    {
        public readonly ApiArtifactKey Source;

        public readonly ApiArtifactKey Target;

        [MethodImpl(Inline)]
        public static implicit operator ArtifactRelation((ApiArtifactKey src, ApiArtifactKey dst) x)
            => new ArtifactRelation(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Pair<ApiArtifactKey>(ArtifactRelation r)
            =>  pair(r.Source, r.Target);

        [MethodImpl(Inline)]
        public ArtifactRelation(ApiArtifactKey src, ApiArtifactKey dst)
        {
            Source = src;
            Target = dst;
        }
    }
}