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
        public readonly ClrArtifactKey Source;

        public readonly ClrArtifactKey Target;

        [MethodImpl(Inline)]
        public static implicit operator ArtifactRelation((ClrArtifactKey src, ClrArtifactKey dst) x)
            => new ArtifactRelation(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Pair<ClrArtifactKey>(ArtifactRelation r)
            =>  pair(r.Source, r.Target);

        [MethodImpl(Inline)]
        public ArtifactRelation(ClrArtifactKey src, ClrArtifactKey dst)
        {
            Source = src;
            Target = dst;
        }
    }
}