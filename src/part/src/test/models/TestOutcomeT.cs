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

    public readonly struct TestOutcome<T> : ITestOutcome<T>
        where T : struct
    {
        public ulong Id {get;}

        public TestCase<T> Case {get;}

        public bool Passed {get;}

        [MethodImpl(Inline)]
        public TestOutcome(ulong id, in TestCase<T> tc, bool passed)
        {
            Id = id;
            Case = tc;
            Passed = passed;
        }

        public Index<T> CaseData
        {
            [MethodImpl(Inline)]
            get => Case.CaseData;
        }
    }
}