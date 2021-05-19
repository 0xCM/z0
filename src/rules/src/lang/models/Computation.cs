//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct Computation
    {
        readonly uint Rule;

        [MethodImpl(Inline)]
        public Computation(uint rule)
        {
            Rule = rule;
        }
    }
}