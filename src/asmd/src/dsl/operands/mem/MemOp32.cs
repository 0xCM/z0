//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct MemOp32 : IMemOp32<MemOp32>
    {
        public Fixed32 Value {get;}

        [MethodImpl(Inline)]
        public MemOp32(Fixed32 src)
        {
            Value = src;
        }
        
        public DataWidth Width => DataWidth.W32;
    }
}