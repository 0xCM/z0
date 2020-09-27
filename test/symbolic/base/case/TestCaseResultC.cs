//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TestCaseResult<C> : ITestCaseResult<C>
        where C : ITestCase
    {
        public C Case {get;}

        public Bit32 Success {get;}

        public string Description {get;}

        public string CaseName
            => Case.CaseName;

        [MethodImpl(Inline)]
        public static implicit operator TestCaseResult(TestCaseResult<C> src)
            => new TestCaseResult(src.CaseName, src.Success, src.Description);

        [MethodImpl(Inline)]
        public TestCaseResult(C tc, Bit32 success, string description)
        {
            Case = tc;
            Success = success;
            Description = description;
        }
    }
}