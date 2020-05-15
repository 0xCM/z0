//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct OperandSize
    {           
        [MethodImpl(Inline)]
        public OperandSize(DataWidth src)
        {
            this.Width = src;
        }

        public readonly DataWidth Width;
    }
}