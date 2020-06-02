//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemOp16 : IMemOp16<MemOp16>        
    {
        [MethodImpl(Inline)]
        public MemOp16(ushort src)
        {
            Data = src;
        }

        public ushort Data {get;}

        public DataWidth Width => DataWidth.W16;
    }
}