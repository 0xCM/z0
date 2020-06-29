//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct imm16 : IImmOp16<imm16>
    {
        public Imm16 Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator imm16(ushort src)
            => new imm16(src);

        [MethodImpl(Inline)]
        public static implicit operator imm16(Imm16 src)
            => new imm16(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator imm16(byte src)
            => new imm16((ushort)src);

        [MethodImpl(Inline)]
        public static bool operator <(imm16 a, imm16 b)
            => a.Content < b.Content;

        [MethodImpl(Inline)]
        public static bool operator >(imm16 a, imm16 b)
            => a.Content > b.Content;

        [MethodImpl(Inline)]
        public static bool operator <=(imm16 a, imm16 b)
            => a.Content <= b.Content;

        [MethodImpl(Inline)]
        public static bool operator >=(imm16 a, imm16 b)
            => a.Content >= b.Content;

        [MethodImpl(Inline)]
        public imm16(byte value)
        {
            Content = value;
        }

        [MethodImpl(Inline)]
        public imm16(Imm16 value)
        {
            Content = value;
        }

        [MethodImpl(Inline)]
        public Address16 ToAddress()
            => Addresses.address16((ushort)Content);

        public DataWidth Width 
            => DataWidth.W16;
    }
}