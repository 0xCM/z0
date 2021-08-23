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

    using W = W8;

    /// <summary>
    /// Defines a refined 8-bit immediate value
    /// </summary>
    [DataType("imm8{k}")]
    public readonly struct Imm8<K> : IImm<Imm8<K>,K>
        where K : unmanaged
    {
        public K Content {get;}

        [MethodImpl(Inline)]
        public Imm8(K src)
            => Content = src;

        public ImmBitWidth Width => ImmBitWidth.W8;

        public ImmKind Kind => ImmKind.Imm8;

        [MethodImpl(Inline)]
        public string Format()
            => HexFormat.format(Content, W, true);

        [MethodImpl(Inline)]
        public byte AsPrimitive()
            => bw8(this);

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
        public static implicit operator K(Imm8<K> src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator byte(Imm8<K> src)
            => src.AsPrimitive();

        [MethodImpl(Inline)]
        public static implicit operator Imm8<K>(K src)
            => new Imm8<K>(src);

        public static W W => default;
    }
}