//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AddressSize
    {           
        [MethodImpl(Inline)]
        public AddressSize(NumericWidth src)
        {
            this.Width = src;
        }

        public readonly NumericWidth Width;
    }
}