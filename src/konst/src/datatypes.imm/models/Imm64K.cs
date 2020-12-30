//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = W64;

    /// <summary>
    /// Defines a refined 64-bit immediate value
    /// </summary>
    [Datatype]
    public readonly struct Imm64<K> : IImmValue<Imm64<K>,W,K>
        where K : unmanaged
    {
        public K Content {get;}

        [MethodImpl(Inline)]
        public Imm64(K src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Content, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Content);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public static implicit operator K(Imm64<K> src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator Imm64<K>(K src)
            => new Imm64<K>(src);

        public static W W => default;
    }
}