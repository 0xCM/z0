//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;
    using static Quartet;

    partial struct Encoding
    {            
        [MethodImpl(Inline)]
        public static bool isrex(byte src)
            => (quartet)(src >> 4) == b0100;

        [MethodImpl(Inline)]
        public static ParseResult<RexPrefix> rex(byte src)
             => isrex(src) 
             ? parsed(src.ToString(), RexPrefix.Define(src)) 
             : unparsed<RexPrefix>(src.ToString(), $"src >> 4 != b0100");
    }
}