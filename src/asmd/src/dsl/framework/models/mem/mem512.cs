//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;

    public readonly struct mem512 : IMemOp512<mem512>
    {
        public Fixed512 Value {get;}

        [MethodImpl(Inline)]
        public mem512(Fixed512 src)
        {
            Value = src;
        }

        public DataWidth Width => DataWidth.W512;
    }
}