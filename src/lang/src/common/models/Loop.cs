//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Loop : ILoop
    {
        public CodeBlock Block {get;}

        public Index<LoopVar> Vars {get;}

        public Loop(CodeBlock block, Index<LoopVar> vars)
        {
            Block = block;
            Vars = vars;
        }
    }
}