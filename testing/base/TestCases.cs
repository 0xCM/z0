//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using static Root;

    using F = TestCaseField;
    using R = TestCaseRecord;

    public interface ITestResultSource
    {
        IEnumerable<TestCaseRecord> TakeOutcomes();
    }

    public interface ITestResultSink : ISink<TestCaseRecord>
    {
        TestCaseRecord ReportOutcome(string casename, bool succeeded, TimeSpan duration);

        void ISink<TestCaseRecord>.Accept(in TestCaseRecord src)
            => ReportOutcome(src.Case, src.Succeeded, src.Duration);
    }
        
    public enum TestCaseField : ulong
    {
        Case = 0 | (75ul << 32),

        Succeeded =  1 | (10ul << 32),

        Duration = 2  | (14ul << 32),
        
        Executed =  3 | (1ul << 32)
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
        public string Case {get;}

        [ReportField(F.Succeeded)]
        public bool Succeeded {get;}

        [ReportField(F.Duration)]
        public readonly Duration Duration;

        [ReportField(F.Executed)]
        public DateTime Executed {get;}

        public string DelimitedText(char delimiter)
        {
            var dst = Model.Formatter.Reset();
            dst.AppendField(F.Case, Case);
            dst.DelimitField(F.Succeeded, Succeeded, delimiter);
            dst.DelimitField(F.Duration, Duration, delimiter);
            dst.DelimitField(F.Executed, Executed, delimiter);
            return dst.ToString();
        }

        static readonly Report<F,R> Model = Report<F,R>.Empty;
    }
}