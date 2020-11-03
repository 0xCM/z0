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

    public readonly struct KindIdentity
    {
        [MethodImpl(Inline)]
        public static implicit operator KindIdentity(in Pair<ClrArtifactKey> src)
            => new KindIdentity(src);

        [MethodImpl(Inline)]
        public KindIdentity(in Pair<ClrArtifactKey> src)
            => Components = (ulong)src.Left | ((ulong)src.Right << 32);

        readonly ulong Components;

        public ClrArtifactKey Host
        {
            [MethodImpl(Inline)]
            get => (uint)Components;
        }

        public ClrArtifactKey Kind
        {
            [MethodImpl(Inline)]
            get => (uint)(Components >> 32);
        }

        public BinaryCode Identifier
        {
            [MethodImpl(Inline)]
            get => bytes(Components);
        }
    }
}