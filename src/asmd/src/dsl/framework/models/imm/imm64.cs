//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct imm64 : IImmOp64<imm64>
    {
        public Fixed64 Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator imm64(ulong src)
            => new imm64(src);

        [MethodImpl(Inline)]
        public static implicit operator imm64(Fixed64 src)
            => new imm64(src);

        [MethodImpl(Inline)]
        public static implicit operator imm64(Fixed8 src)
            => new imm64(src);

        [MethodImpl(Inline)]
        public static implicit operator imm64(Fixed16 src)
            => new imm64(src);

        [MethodImpl(Inline)]
        public static implicit operator imm64(Fixed32 src)
            => new imm64(src);

        [MethodImpl(Inline)]
        public imm64(Fixed64 value)
        {
            Value = value;
        }
        
        public DataWidth Width 
            => DataWidth.W64;

        [MethodImpl(Inline)]
        public Address64 ToAddress()
            => Addresses.address64((ulong)Value);

        public string Format()
            => Value.FormatHex();

        public override string ToString()
            => Format();
    } 
}