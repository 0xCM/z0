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

    public readonly struct TestCaseResultSet<T>
        where T : struct, ITestCase<T>
    {
        readonly Index<TestCaseResult<T>> Data;

        [MethodImpl(Inline)]
        public TestCaseResultSet(Index<TestCaseResult<T>> src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator TestCaseResultSet<T>(TestCaseResult<T>[] src)
            => new TestCaseResultSet<T>(src);
    }
}