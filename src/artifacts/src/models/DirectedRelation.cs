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

    /// <summary>
    /// Defines a directed association from one artifact to another
    /// </summary>
    public readonly struct DirectedRelation
    {
        public readonly ArtifactIdentifier Source;

        public readonly ArtifactIdentifier Target;

        [MethodImpl(Inline)]
        public static implicit operator DirectedRelation((ArtifactIdentifier src, ArtifactIdentifier dst) x)
            => new DirectedRelation(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Pair<ArtifactIdentifier>(DirectedRelation r)
            =>  pair(r.Source, r.Target);

        [MethodImpl(Inline)]
        public DirectedRelation(ArtifactIdentifier src, ArtifactIdentifier dst)
        {
            Source = src;
            Target = dst;
        }
    }
}