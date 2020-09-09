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
        public readonly ArtifactIdentifier Source;

        public readonly ArtifactIdentifier Target;

        [MethodImpl(Inline)]
        public static implicit operator ArtifactRelation((ArtifactIdentifier src, ArtifactIdentifier dst) x)
            => new ArtifactRelation(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Pair<ArtifactIdentifier>(ArtifactRelation r)
            =>  pair(r.Source, r.Target);

        [MethodImpl(Inline)]
        public ArtifactRelation(ArtifactIdentifier src, ArtifactIdentifier dst)
        {
            Source = src;
            Target = dst;
        }
    }
}