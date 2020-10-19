//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a reference to clr-specific artifact
    /// </summary>
    public readonly struct ClrArtifactRef<A> : IClrArtifactRef<A>
        where A : struct, IClrArtifact<A>
    {
        readonly A Artifact;

        public ClrArtifactKind Kind => Artifact.Kind;

        public ClrArtifactKey Key  => Artifact.Id;

        public StringRef Name => Artifact.Name;

        [MethodImpl(Inline)]
        public ClrArtifactRef(A artifact)
            => Artifact = artifact;

        public static implicit operator ClrArtifactRef<A>(A src)
            => new ClrArtifactRef<A>(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrArtifactRef(ClrArtifactRef<A> src)
            => new ClrArtifactRef(src.Key, src.Kind, src.Name);
    }
}