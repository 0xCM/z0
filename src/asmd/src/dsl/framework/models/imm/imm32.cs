//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct imm32 : IImmAddress32<imm32>
    {
        public Imm32 Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator imm32(uint src)
            => new imm32(src);

        [MethodImpl(Inline)]
        public static implicit operator imm32(Imm32 src)
            => new imm32(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator imm32(Fixed16 src)
            => new imm32(src);


        [MethodImpl(Inline)]
        public static bool operator <(imm32 a, imm32 b)
            => a.Content < b.Content;

        [MethodImpl(Inline)]
        public static bool operator >(imm32 a, imm32 b)
            => a.Content > b.Content;

        [MethodImpl(Inline)]
        public static bool operator <=(imm32 a, imm32 b)
            => a.Content <= b.Content;

        [MethodImpl(Inline)]
        public static bool operator >=(imm32 a, imm32 b)
            => a.Content >= b.Content;

        [MethodImpl(Inline)]
        public imm32(uint src)
        {
            Content = src;
        }

        [MethodImpl(Inline)]
        public Address32 ToAddress()
            => Addresses.address32((uint)Content);

        public DataWidth Width 
            => DataWidth.W32;
    } 
}