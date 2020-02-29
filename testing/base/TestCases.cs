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
            => ReportOutcome(src.Case, src.Status != 0, src.Duration);
    }
        
    public enum TestCaseField : ulong
    {
        Case = 0 | (80ul << 32),

        Status =  1 | (14ul << 32),

        Duration = 2  | (14ul << 32),
        
        Executed =  3 | (26ul << 32)
    }

    public enum TestCaseStatus : byte
    {
        Failed = 0,

        Passed = 1
    }

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public class TestCaseRecord : IRecord<F,R>
    {        
        public static TestCaseRecord Define(string name, bool succeeded, Duration duration)
            => new TestCaseRecord(name, succeeded, duration);
        
        TestCaseRecord(string name, bool succeeded, Duration duration)
        {
            this.Case = name;
            this.Status = succeeded ? TestCaseStatus.Passed : TestCaseStatus.Failed;
            this.Duration = duration;
            this.Executed = DateTime.Now;
        }

        [ReportField(F.Case)]
        public string Case {get;}

        [ReportField(F.Status)]
        public TestCaseStatus Status {get;}

        [ReportField(F.Duration)]
        public readonly Duration Duration;

        [ReportField(F.Executed)]
        public DateTime Executed {get;}

        public string DelimitedText(char delimiter)
        {
            var dst = Model.Formatter.Reset();
            dst.AppendField(F.Case, Case);
            dst.DelimitField(F.Status, Status, delimiter);
            dst.DelimitField(F.Duration, Duration, delimiter);            
            dst.DelimitField(F.Executed, Executed, delimiter);
            return dst.ToString();
        }

        static readonly Report<F,R> Model = Report<F,R>.Empty;
    }
}