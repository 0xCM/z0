//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Imm8<E>
        where E : unmanaged, Enum
    {
        public readonly @enum<E,byte> Value;

        [MethodImpl(Inline)]
        public Imm8(@enum<E,byte> value)
        {
            Value = value;
        }
    }    

    public readonly struct imm8 : IImmOp8<imm8>
    {
        public byte Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator imm8(byte src)
            => new imm8(src);

        [MethodImpl(Inline)]
        public static implicit operator imm8(Fixed8 src)
            => new imm8(src);

        [MethodImpl(Inline)]
        public static bool operator <(imm8 a, imm8 b)
            => a.Value < b.Value;

        [MethodImpl(Inline)]
        public static bool operator >(imm8 a, imm8 b)
            => a.Value > b.Value;

        [MethodImpl(Inline)]
        public static bool operator <=(imm8 a, imm8 b)
            => a.Value <= b.Value;

        [MethodImpl(Inline)]
        public static bool operator >=(imm8 a, imm8 b)
            => a.Value >= b.Value;

        [MethodImpl(Inline)]
        public imm8(Fixed8 value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public Address8 ToAddress()
            => Addresses.address8((byte)Value);

        public DataWidth Width 
            => DataWidth.W8;
    }
}