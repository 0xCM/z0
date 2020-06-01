//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemOp8 : IMemOp8<MemOp8>
    {
        [MethodImpl(Inline)]
        public MemOp8(byte src)
        {
            Data = src;
        }
        
        public byte Data {get;}

        public DataWidth Width => DataWidth.W8;
    }
}