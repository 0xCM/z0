//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TestCase<T> : ITestCase<T>
        where T : struct
    {
        public Name CaseName {get;}

        public Index<T> CaseData {get;}

        [MethodImpl(Inline)]
        public TestCase(Name name, Index<T> src)
        {
            CaseName = name;
            CaseData = src;
        }
    }
}