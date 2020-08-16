//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using W = W16;
    using I = Imm16;

    /// <summary>
    /// Defines a refined 16-bit immediate value
    /// </summary>
    public readonly struct Imm16<E> : IAsmOperand<Imm16<E>,W16, E>
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
        public static implicit operator E(Imm16<E> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Imm16<E>(E src)
            => new Imm16<E>(src);

        [MethodImpl(Inline)]
        public Imm16(E value)
        {
            Data = value;
        }

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