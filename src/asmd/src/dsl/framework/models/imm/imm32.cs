//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct imm32 : IImmOp32<imm32>
    {
        public uint Value {get;}


        [MethodImpl(Inline)]
        public static implicit operator imm32(uint src)
            => new imm32(src);

        [MethodImpl(Inline)]
        public static implicit operator imm32(Fixed8 src)
            => new imm32(src);

        [MethodImpl(Inline)]
        public static implicit operator imm32(Fixed16 src)
            => new imm32(src);


        [MethodImpl(Inline)]
        public static bool operator <(imm32 a, imm32 b)
            => a.Value < b.Value;

        [MethodImpl(Inline)]
        public static bool operator >(imm32 a, imm32 b)
            => a.Value > b.Value;

        [MethodImpl(Inline)]
        public static bool operator <=(imm32 a, imm32 b)
            => a.Value <= b.Value;

        [MethodImpl(Inline)]
        public static bool operator >=(imm32 a, imm32 b)
            => a.Value >= b.Value;

        [MethodImpl(Inline)]
        public imm32(uint value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public Address32 ToAddress()
            => Addresses.address32((uint)Value);

        public DataWidth Width 
            => DataWidth.W32;
    } 
}