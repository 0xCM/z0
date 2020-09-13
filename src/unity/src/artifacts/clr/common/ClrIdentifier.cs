//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    public readonly struct ClrIdentifier<A> : IClrIdentifier<A>
        where A : struct, IClrArtifact<A>
    {
        public ArtifactIdentifier ArtifactId {get;}

        public ClrTypeCode ArtifactType {get;}

        [MethodImpl(Inline)]
        public static implicit operator ClrIdentifier<A>(ArtifactIdentifier src)
            => new ClrIdentifier<A>(src);

        [MethodImpl(Inline)]
        public ClrIdentifier(ArtifactIdentifier src)
        {
            ArtifactId = src;
            ArtifactType = default;
        }
    }
}