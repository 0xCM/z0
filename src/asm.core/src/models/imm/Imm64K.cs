//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using W = W64;

    /// <summary>
    /// Defines a refined 64-bit immediate value
    /// </summary>
    [DataType("imm64{k}")]
    public readonly struct Imm64<K> : IImm<Imm64<K>,K>
        where K : unmanaged
    {
        public K Content {get;}

        public ImmBitWidth Width => ImmBitWidth.W64;

        public ImmKind Kind => ImmKind.Imm64;

        [MethodImpl(Inline)]
        public Imm64(K src)
            => Content = src;

        [MethodImpl(Inline)]
        public ulong AsPrimitive()
            => bw64(this);

        public string Format()
            => HexFormat.format(Content, W, true);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc(Content);
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