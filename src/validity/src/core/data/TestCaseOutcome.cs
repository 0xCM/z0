//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public readonly struct TestCaseOutcome
    {
        public static TestCaseOutcome Define(string name, bool succeeded, TimeSpan duration)
            => new TestCaseOutcome(name, succeeded, duration);

        TestCaseOutcome(string name, bool succeeded, TimeSpan duration)
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