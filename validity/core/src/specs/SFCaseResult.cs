//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class SFCaseResult
    {
        public static implicit operator TestCaseOutcome(SFCaseResult src)
            => TestCaseOutcome.Define(src.CaseName, src.Succeeded, src.Duration);
        
        public SFCaseResult(string name, bool succeeded, TimeSpan duration, AppMsg msg = null)
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