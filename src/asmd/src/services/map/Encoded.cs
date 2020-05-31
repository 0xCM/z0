//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public partial class HexMapper
    {
        public readonly struct Encoded
        {
            [MethodImpl(Inline)]
            public Encoded(HexKind[] src)
            {
                this.Data = src;
            }
            
            public readonly HexKind[] Data;
            
        }    
    }
}
