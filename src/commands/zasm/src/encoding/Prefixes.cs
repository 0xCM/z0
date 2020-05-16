//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;        
    using static Memories;
    using static BinaryKind4;

    public class Prefixes
    {
        [MethodImpl(Inline)]
        public static bool IsRex(byte src)
            => (uint4_t)(src >> 4) == b0100;
            
        [MethodImpl(Inline)]
        public static ParseResult<RexPrefix> ParseRex(byte src)
             => IsRex(src) 
             ? parsed(src.ToString(), new RexPrefix(src)) 
             : unparsed<RexPrefix>(src.ToString(), $"src >> 4 != b0100");

        [MethodImpl(Inline)]
        public static ModRm ParseModRM(byte src)
            => new ModRm(src);
    }
}