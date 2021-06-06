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

    public readonly struct TestOutcome<C,T,R> : ITestOutcome<C,T,R>
        where C : struct
        where T : struct
        where R : struct
    {
        public ulong Id {get;}

        public TestCase<C> Case {get;}

        public Index<T> Input {get;}

        public Index<R> Output {get;}

        public bool Passed {get;}

        [MethodImpl(Inline)]
        public TestOutcome(ulong id, TestCase<C> tc, Index<T> input, Index<R> output, bool passed)
        {
            Id = id;
            Case = tc;
            Input = input;
            Output = output;
            Passed = passed;
        }

        public Index<C> CaseData
        {
            [MethodImpl(Inline)]
            get => Case.CaseData;
        }
    }
}