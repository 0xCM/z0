//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class FuncCompareResult
    {
        public static implicit operator TestCaseOutcome(FuncCompareResult src)
            => new TestCaseOutcome(src.CaseName, src.Succeeded, src.Duration);
        
        public FuncCompareResult(string name, bool succeeded, TimeSpan duration, AppMsg msg = null)
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