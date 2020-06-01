//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct MemOp512 : IMemOp512<MemOp512>
    {
        [MethodImpl(Inline)]
        public MemOp512(Vector512<byte> src)
        {
            Data = src;
        }

        public Vector512<byte> Data {get;}

        public DataWidth Width => DataWidth.W512;
    }
}