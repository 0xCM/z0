//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = W8;

    /// <summary>
    /// Defines a refined 8-bit immediate value
    /// </summary>
    public readonly struct Imm8<E> : IAsmArg<Imm8<E>,W,E>
        where E : unmanaged, Enum
    {
        public readonly E Data;

        public static W W => default;

        public E Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public AsmOperandKind OpKind
        {
            [MethodImpl(Inline)]
            get => AsmOperandKind.Imm;
        }

        [MethodImpl(Inline)]
        public static implicit operator E(Imm8<E> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm8<E>(E src)
            => new Imm8<E>(src);

        [MethodImpl(Inline)]
        public Imm8(E src)
            => Data = src;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format(Data, W);

        public override string ToString()
            => Format();

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Data);
        }

        public override int GetHashCode()
            => (int)Hash;
    }
}