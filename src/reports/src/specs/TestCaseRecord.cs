//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using F = TestCaseField;
    using R = TestCaseRecord;
        
    public enum TestCaseField : int
    {
        Case = 0 | (60 << 16),

        Status =  1 | (14 << 16),

        Duration = 2  | (14 << 16),
        
        Executed =  3 | (26 << 16)
    }

    public enum TestCaseStatus : byte
    {
        Failed = 0,

        Passed = 1
    }

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public class TestCaseRecord : ITabular<F,R>
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

        [TabularField(F.Case)]
        public string Case {get;}

        [TabularField(F.Status)]
        public TestCaseStatus Status {get;}

        [TabularField(F.Duration)]
        public readonly Duration Duration;

        [TabularField(F.Executed)]
        public DateTime Executed {get;}

        string[] ITabular.HeaderNames
            => TabularFormats.headers<R>();

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