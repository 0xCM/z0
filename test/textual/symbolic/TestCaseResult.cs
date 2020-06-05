//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct TestCaseResult<C>
    {
        [MethodImpl(Inline)]
        public TestCaseResult(C tc, bit success, string description)
        {
            Case = tc;
            Success = success;
            Description = description;
        }
        
        public readonly C Case;

        public readonly bit Success;

        public readonly string Description;
    }
}