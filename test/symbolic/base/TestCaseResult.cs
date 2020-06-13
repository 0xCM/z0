//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TestCaseResult : ITestCaseResult
    {

        public string CaseName {get;}

        public bit Success {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public TestCaseResult(string name, bit success, string description)
        {
            CaseName = name;
            Success = success;
            Description = description;
        }
    }
}