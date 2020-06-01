//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static RegisterField ToBitField(this RegisterKind src)
            => new RegisterField(src);
    }    
}