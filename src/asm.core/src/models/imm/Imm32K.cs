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

    using W = W32;

    /// <summary>
    /// Defines a refined 32-bit immediate value
    /// </summary>
    [DataType("imm32{k}")]
    public readonly struct Imm32<K> : IImm<Imm32<K>, K>
        where K : unmanaged
    {
        public K Content {get;}

        public static W W => default;

        public ImmWidthCode Width => ImmWidthCode.W32;

        public ImmKind Kind => ImmKind.Imm32;

        [MethodImpl(Inline)]
        public static implicit operator K(Imm32<K> src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator Imm32<K>(K src)
            => new Imm32<K>(src);

        [MethodImpl(Inline)]
        public Imm32(K src)
            => Content = src;

        [MethodImpl(Inline)]
        public uint AsPrimitive()
            => bw32(this);


        [MethodImpl(Inline)]
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
    }
}