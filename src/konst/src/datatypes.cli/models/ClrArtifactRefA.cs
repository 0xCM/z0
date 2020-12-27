//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a reference to clr-specific artifact
    /// </summary>
    public readonly struct ClrArtifactRef<A> : IClrArtifact<A>
        where A : struct, IClrArtifact<A>
    {
        readonly A Artifact;

        public ClrArtifactKind Kind
        {
            [MethodImpl(Inline)]
            get => Artifact.Kind;
        }

        public ClrToken Key
        {
            [MethodImpl(Inline)]
            get => Artifact.Key;
        }

        public StringRef Name
        {
            [MethodImpl(Inline)]
            get => Artifact.Name;
        }

        string IClrArtifact.Name
            => Name;

        [MethodImpl(Inline)]
        public ClrArtifactRef(A artifact)
            => Artifact = artifact;

        public static implicit operator ClrArtifactRef<A>(A src)
            => new ClrArtifactRef<A>(src);

        [MethodImpl(Inline)]
        public static implicit operator CliArtifactRef(ClrArtifactRef<A> src)
            => new CliArtifactRef(src.Key, src.Kind, src.Name);
    }
}