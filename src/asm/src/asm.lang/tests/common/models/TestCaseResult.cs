//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct TestCaseResult<T> : ITestCaseResult<T>
        where T : struct, ITestCase<T>
    {
        public ulong Id {get;}

        public T Case {get;}

        public bool Passed {get;}

        [MethodImpl(Inline)]
        public TestCaseResult(ulong id, in T tc, bool passed)
        {
            Id = id;
            Case = tc;
            Passed = passed;
        }
    }
}