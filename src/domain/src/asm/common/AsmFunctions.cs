//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct AsmFunctions
    {                        
        public readonly AsmFunction[] Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmFunctions(AsmFunction[] src)
            => new AsmFunctions(src);

        [MethodImpl(Inline)]
        public AsmFunctions(AsmFunction[] src)
            => Data = src;        
    }
}