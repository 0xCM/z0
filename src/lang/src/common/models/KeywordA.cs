//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a parametric keyword
    /// </summary>
    public readonly struct Keyword<A>
    {
        public MemoryAddress Name {get;}

        public A Arg {get;}

        [MethodImpl(Inline)]
        public Keyword(MemoryAddress src, A arg)
        {
            Name = src;
            Arg = arg;
        }
    }
}