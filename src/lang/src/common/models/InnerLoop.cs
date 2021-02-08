//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct InnerLoop : ILoop
    {
        public ILoop Outer {get;}

        public CodeBlock Block {get;}

        [MethodImpl(Inline)]
        public InnerLoop(ILoop outer, CodeBlock block)
        {
            Outer = outer;
            Block = block;
        }
    }
}