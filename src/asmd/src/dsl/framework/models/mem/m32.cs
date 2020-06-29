//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct m32 : IMemOp32<m32>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator m32(uint src)
            => new m32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(m32 src)
            => src.Content;

        [MethodImpl(Inline)]
        public m32(uint src)
        {
            Content = src;
        }
        
        public DataWidth Width
            => DataWidth.W32;
    }
}