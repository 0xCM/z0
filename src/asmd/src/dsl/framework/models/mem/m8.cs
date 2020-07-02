//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct m8 : IMemOperand8<m8,byte>
    {
        public readonly byte Data;

        [MethodImpl(Inline)]
        public static implicit operator m8(byte src)
            => new m8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(m8 src)
            => src.Data;

        [MethodImpl(Inline)]
        public m8(byte src)
            => Data = src;

        public DataWidth Width 
            => DataWidth.W8;

        byte IOperand<byte>.Content 
            => Data;
    }
}