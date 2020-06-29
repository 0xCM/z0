//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an 8-bit immediate operand
    /// </summary>
    public readonly struct imm8 : IImmOp8<imm8>
    {
        public Imm8 Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator imm8(Imm8 src)
            => new imm8(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator imm8(byte src)
            => new imm8(src);

        [MethodImpl(Inline)]
        public static bool operator <(imm8 a, imm8 b)
            => a.Content < b.Content;

        [MethodImpl(Inline)]
        public static bool operator >(imm8 a, imm8 b)
            => a.Content > b.Content;

        [MethodImpl(Inline)]
        public static bool operator <=(imm8 a, imm8 b)
            => a.Content <= b.Content;

        [MethodImpl(Inline)]
        public static bool operator >=(imm8 a, imm8 b)
            => a.Content >= b.Content;

        [MethodImpl(Inline)]
        public imm8(Imm8 value)
        {
            Content = value;
        }

        [MethodImpl(Inline)]
        public Address8 ToAddress()
            => Addresses.address8((byte)Content);

        public DataWidth Width 
            => DataWidth.W8;
    }
}