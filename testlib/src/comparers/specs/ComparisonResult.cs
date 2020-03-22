//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    public class ComparisonResult
    {
        public static implicit operator TestCaseOutcome(ComparisonResult src)
            => new TestCaseOutcome(src.CaseName, src.Succeeded, src.Duration);
        
        public ComparisonResult(string name, bool succeeded, TimeSpan duration, AppMsg msg = null)
        {
            this.CaseName = name;
            this.Succeeded = succeeded;
            this.Duration = duration;
            this.Message = msg ?? AppMsg.Empty;
        }

        public string CaseName {get;}

        public bool Succeeded {get;}

        public TimeSpan Duration {get;}

        public AppMsg Message {get;}
    }
}