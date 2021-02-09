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
        public IScope Scope => Outer;

        public ILoop Outer {get;}

        public CodeBlock Body {get;}

        [MethodImpl(Inline)]
        public InnerLoop(ILoop outer, CodeBlock body)
        {
            Outer = outer;
            Body = body;
        }
    }
}