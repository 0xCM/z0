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
    public readonly struct ClrArtifactIdentity
    {
        public ClrArtifactKind Kind {get;}

        public ClrArtifactKey Key {get;}

        [MethodImpl(Inline)]
        public ClrArtifactIdentity(ClrArtifactKind kind, ClrArtifactKey key)
        {
            Kind = kind;
            Key = key;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrArtifactIdentity(ArtifactIdentity<ClrArtifactKind,ClrArtifactKey> src)
            => new ClrArtifactIdentity(src.Kind, src.Key);

        [MethodImpl(Inline)]
        public static implicit operator ArtifactIdentity<ClrArtifactKind,ClrArtifactKey>(ClrArtifactIdentity src)
            => new ArtifactIdentity<ClrArtifactKind,ClrArtifactKey>(src.Kind, src.Key);
    }
}