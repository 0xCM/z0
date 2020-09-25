//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = ValueTypes;

    /// <summary>
    /// Identifies an artifact
    /// </summary>
    public readonly struct ArtifactIdentity<K,I> : IEquatable<ArtifactIdentity<K,I>>, ITextual
        where I : unmanaged
        where K : unmanaged
    {
        /// <summary>
        /// The identified artifact kind
        /// </summary>
        public readonly K Kind;

        /// <summary>
        /// The artifact id over the <typeparamref name='K'/>-discriminated domain
        /// </summary>
        public readonly I Key;

        [MethodImpl(Inline), Op]
        public static implicit operator ArtifactIdentity<K,I>((K kind, I id) src)
            => new ArtifactIdentity<K,I>(src.kind, src.id);

        [MethodImpl(Inline), Op]
        public static implicit operator ArtifactIdentity<K,I>(Paired<K,I> src)
            => new ArtifactIdentity<K,I>(src.Left, src.Right);

        [MethodImpl(Inline), Op]
        public ArtifactIdentity(K kind, I id)
        {
            Kind = kind;
            Key = id;
        }

        [MethodImpl(Inline), Op]
        public string Format()
            => text.format(RP.SlotDot2, Kind, Key);

        [MethodImpl(Inline), Op]
        public bool Equals(ArtifactIdentity<K,I> src)
            => api.eq(this,src);

        [MethodImpl(Inline), Op]
        public override int GetHashCode()
            => (int)api.hash(this);

        public override bool Equals(object src)
            => src is ArtifactIdentity<K,I> x && Equals(x);

        public Span<byte> Edit
        {
            [MethodImpl(Inline), Op]
            get => api.edit(this);
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline), Op]
            get => api.view(this);
        }
    }
}