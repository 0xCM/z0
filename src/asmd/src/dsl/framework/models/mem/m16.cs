//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct m16 : IMemOperand16<m16,ushort>        
    {
        public readonly ushort Data;

        [MethodImpl(Inline)]
        public static implicit operator m16(ushort src)
            => new m16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(m16 src)
            => src.Data;

        [MethodImpl(Inline)]
        public m16(ushort src)
            => Data = src;

        ushort IOperand<ushort>.Content 
            => Data;
        public DataWidth Width 
            => DataWidth.W16;
    }
}