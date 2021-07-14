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

    using W = W16;

    /// <summary>
    /// Defines a refined 16-bit immediate value
    /// </summary>
    [DataType("imm16{k}")]
    public readonly struct Imm16<K> : IImm<Imm16<K>, K>
        where K : unmanaged
    {
        public K Content {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public Imm16(K value)
            => Content = value;

        public ImmWidth Width => ImmWidth.W16;


        public ImmKind Kind => ImmKind.Imm16;

        [MethodImpl(Inline)]
        public string Format()
            => HexFormat.format(Content, W);

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
        public ushort AsPrimitive()
            => bw16(this);

        [MethodImpl(Inline)]
        public static implicit operator K(Imm16<K> src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator Imm16<K>(K src)
            => new Imm16<K>(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(Imm16<K> src)
            => src.AsPrimitive();

    }
}