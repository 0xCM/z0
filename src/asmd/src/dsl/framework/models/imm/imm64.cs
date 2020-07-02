//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using W = W64;

    public readonly struct imm64 : IImmAddress64<imm64>
    {
        public Imm64 Content {get;}

        public static W W => default;

        [MethodImpl(Inline)]
        public static implicit operator imm64(ulong src)
            => new imm64(src);

        [MethodImpl(Inline)]
        public static implicit operator imm64(Fixed8 src)
            => new imm64(src);

        [MethodImpl(Inline)]
        public static implicit operator imm64(Imm64 src)
            => new imm64(src.Data);

        [MethodImpl(Inline)]
        public static bool operator <(imm64 a, imm64 b)
            => a.Content < b.Content;

        [MethodImpl(Inline)]
        public static bool operator >(imm64 a, imm64 b)
            => a.Content > b.Content;

        [MethodImpl(Inline)]
        public static bool operator <=(imm64 a, imm64 b)
            => a.Content <= b.Content;

        [MethodImpl(Inline)]
        public static bool operator >=(imm64 a, imm64 b)
            => a.Content >= b.Content;

        [MethodImpl(Inline)]
        public imm64(ulong value)
        {
            Content = value;
        }
        
        public DataWidth Width 
            => DataWidth.W64;

        [MethodImpl(Inline)]
        public Address64 ToAddress()
            => Addressable.address(W, (ulong)Content);

        public string Format()
            => Content.Data.FormatHex();

        public override string ToString()
            => Format();
    } 
}