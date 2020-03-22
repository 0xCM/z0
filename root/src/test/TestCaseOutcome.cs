//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    public class TestCaseOutcome
    {
        public static TestCaseOutcome Define(string name, bool succeeded, TimeSpan duration)
            => new TestCaseOutcome(name, succeeded, duration);

        public TestCaseOutcome(string name, bool succeeded, TimeSpan duration)
        {
            this.CaseName = name;
            this.Succeeded = succeeded;
            this.Duration = duration;
        }

        public string CaseName {get;}

        public bool Succeeded {get;}

        public TimeSpan Duration {get;}
    }
}