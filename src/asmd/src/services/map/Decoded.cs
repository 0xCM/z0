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
        public readonly struct Decoded
        {
            [MethodImpl(Inline)]
            public Decoded(AsciCharCode[] src)
            {
                this.Data = src;
            }
            
            public readonly AsciCharCode[] Data;
            
        }    
    }
}
