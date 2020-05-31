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

    struct OpCodeParser
    {        
        public static OpCodeParser Service => default(OpCodeParser);

        public OpCodeSpec Parse(OpCodeExpression src)            
        {
            var components = src.Content.SplitClean(Chars.Space).Map(c => new OpCodePart(c));
            return new OpCodeSpec(src,components);            
        }
    }
}