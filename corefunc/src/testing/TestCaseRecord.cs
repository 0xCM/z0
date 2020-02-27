//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using static zfunc;

    using F = TestCaseField;
    using R = TestCaseRecord;

    enum TestCaseField
    {

        Case = 75,

        Succeeded = 10,

        Duration = 10,
        
        Executed = 1
    }

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public class TestCaseRecord : IRecord<F,R>
    {
        const string YEA = "verified";
        
        const string BOO = "failed";

        public static TestCaseRecord Define(string name, bool success, Duration duration)
            => new TestCaseRecord(name, success, duration);
        
        TestCaseRecord(string Case, bool Succeeded, Duration Duration)
        {
            this.Case = Case;
            this.Succeeded = Succeeded;
            this.Duration = Duration;
            this.Executed = now();
        }

        [ReportField(F.Case)]
        public string Case {get;set;}

        [ReportField(F.Succeeded)]
        public bool Succeeded {get;set;}

        [ReportField(F.Duration)]
        public Duration Duration {get;set;}

        [ReportField(F.Executed)]
        public DateTime Executed {get;set;}

        public string DelimitedText(char delimiter)
        {
            var dst = text.factory.Builder();
            dst.AppendField(Case, F.Case);
            dst.DelimitField(Succeeded ? YEA : BOO, F.Succeeded, delimiter);
            dst.DelimitField(Duration, F.Duration, delimiter);
            dst.DelimitField(Executed, delimiter);
            return dst.ToString();
        }
    }
}