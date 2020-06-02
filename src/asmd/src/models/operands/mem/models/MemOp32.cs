//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemOp32 : IMemOp32<MemOp32>
    {
        [MethodImpl(Inline)]
        public MemOp32(uint src)
        {
            Data = src;
        }

        public uint Data {get;}

        public DataWidth Width => DataWidth.W32;
    }
}