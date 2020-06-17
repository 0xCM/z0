//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;        
    using static Memories;
    using static Quartet;

    public partial class Prefixes
    {
        [MethodImpl(Inline)]
        public static bool IsRex(byte src)
            => (quartet)(src >> 4) == b0100;
            
        [MethodImpl(Inline)]
        public static ParseResult<RexPrefix> ParseRex(byte src)
             => IsRex(src) 
             ? parsed(src.ToString(), RexPrefix.Define(src)) 
             : unparsed<RexPrefix>(src.ToString(), $"src >> 4 != b0100");

        [MethodImpl(Inline)]
        public static ModRm ParseModRM(byte src)
            => new ModRm(src);
    }
}