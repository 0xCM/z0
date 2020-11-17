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

    using api = Values;

    public readonly struct KindedIdentity<K,I> : IEquatable<KindedIdentity<K,I>>, ITextual
        where I : unmanaged
        where K : unmanaged
    {
        /// <summary>
        /// The identifier kind
        /// </summary>
        public readonly K Kind;

        /// <summary>
        /// The id over the <typeparamref name='K'/>-discriminated domain
        /// </summary>
        public readonly I Key;

        [MethodImpl(Inline), Op]
        public KindedIdentity(K kind, I id)
        {
            Kind = kind;
            Key = id;
        }

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

        [MethodImpl(Inline), Op]
        public string Format()
            => text.format(RP.SlotDot2, Kind, Key);

        [MethodImpl(Inline), Op]
        public bool Equals(KindedIdentity<K,I> src)
            => api.eq(this,src);

        [MethodImpl(Inline), Op]
        public override int GetHashCode()
            => (int)api.hash(this);

        public override bool Equals(object src)
            => src is KindedIdentity<K,I> x && Equals(x);

        [MethodImpl(Inline), Op]
        public static implicit operator KindedIdentity<K,I>((K kind, I id) src)
            => new KindedIdentity<K,I>(src.kind, src.id);

        [MethodImpl(Inline), Op]
        public static implicit operator KindedIdentity<K,I>(Paired<K,I> src)
            => new KindedIdentity<K,I>(src.Left, src.Right);
    }
}