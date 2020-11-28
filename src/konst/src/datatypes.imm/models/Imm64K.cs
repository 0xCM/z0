//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = W64;

    /// <summary>
    /// Defines a refined 64-bit immediate value
    /// </summary>
    [DataType]
    public readonly struct Imm64<K> : IImmValue<Imm64<K>,W,K>
        where K : unmanaged
    {
        public K Storage {get;}

        [MethodImpl(Inline)]
        public Imm64(K src)
            => Storage = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Storage, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Storage);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public static implicit operator K(Imm64<K> src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator Imm64<K>(K src)
            => new Imm64<K>(src);

        public static W W => default;
    }
}