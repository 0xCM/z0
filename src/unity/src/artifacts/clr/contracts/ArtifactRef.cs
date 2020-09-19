//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ClrArtifactRef : IClrArtifactRef
    {
        public ClrArtifactKind Kind {get;}

        public ArtifactIdentifier Id {get;}

        public ClrName Name {get;}

        [MethodImpl(Inline)]
        public ClrArtifactRef(ArtifactIdentifier id, ClrArtifactKind kind, ClrName name)
        {
            Id = id;
            Kind = kind;
            Name = name;
        }
    }

    public readonly struct ClrArtifactRef<A> : IClrArtifactRef<A>
        where A : struct, IClrArtifact<A>
    {
        readonly A Artifact;

        public ClrArtifactKind Kind => Artifact.Kind;

        public ArtifactIdentifier Id  => Artifact.Id;

        public ClrName Name  => Artifact.Name;

        [MethodImpl(Inline)]
        public ClrArtifactRef(A artifact)
            => Artifact = artifact;

        public static implicit operator ClrArtifactRef<A>(A src)
            => new ClrArtifactRef<A>(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrArtifactRef(ClrArtifactRef<A> src)
            => new ClrArtifactRef(src.Id, src.Kind, src.Name);
    }
}