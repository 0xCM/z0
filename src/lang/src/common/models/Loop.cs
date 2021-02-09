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
        public IScope Scope {get;}

        public CodeBlock Body {get;}

        public Loop(IScope scope, CodeBlock block)
        {
            Scope = scope;
            Body = block;
        }
    }
}