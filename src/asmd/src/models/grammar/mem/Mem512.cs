//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct Mem512 : IMemory512<Mem512>
    {
        [MethodImpl(Inline)]
        public Mem512(Vector512<byte> src)
        {
            Value = src;
        }

        public Vector512<byte> Value {get;}

        public DataWidth Width => DataWidth.W512;
    }
}