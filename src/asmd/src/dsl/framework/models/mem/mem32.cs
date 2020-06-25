//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct mem32 : IMemOp32<mem32>
    {
        public Fixed32 Value {get;}

        [MethodImpl(Inline)]
        public mem32(Fixed32 src)
        {
            Value = src;
        }
        
        public DataWidth Width => DataWidth.W32;
    }
}