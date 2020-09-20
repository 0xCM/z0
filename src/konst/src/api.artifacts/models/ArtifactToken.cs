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
    public readonly struct ArtifactToken<K,I> : IEquatable<ArtifactToken<K,I>>, ITextual
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
        public readonly I Id;

        [MethodImpl(Inline), Op]
        public static implicit operator ArtifactToken<K,I>((K kind, I id) src)
            => new ArtifactToken<K,I>(src.kind, src.id);

        [MethodImpl(Inline), Op]
        public static implicit operator ArtifactToken<K,I>(Paired<K,I> src)
            => new ArtifactToken<K,I>(src.Left, src.Right);

        [MethodImpl(Inline), Op]
        public ArtifactToken(K kind, I id)
        {
            Kind = kind;
            Id = id;
        }

        [MethodImpl(Inline), Op]
        public string Format()
            => text.format(RenderPatterns.SlotDot2, Kind, Id);

        [MethodImpl(Inline), Op]
        public bool Equals(ArtifactToken<K,I> src)
            => api.eq(this,src);

        [MethodImpl(Inline), Op]
        public override int GetHashCode()
            => (int)api.hash(this);

        public override bool Equals(object src)
            => src is ArtifactToken<K,I> x && Equals(x);

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