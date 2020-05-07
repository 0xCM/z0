//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;         

    using RF = RexFieldIndex;   

    public readonly struct RexPrefixRender : IRender<RexPrefix>
    {
        public static RexPrefixRender Service => default(RexPrefixRender);

        public string Render(RexPrefix src)
            => $"{RF.Code}:{src.Code} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B}";
    }
}