//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    using F = TestCaseField;
    using R = TestCaseRecord;
        
    public enum TestCaseField : uint
    {
        Case = 0 | (60 << WidthOffset),

        Status =  1 | (14 << WidthOffset),

        Duration = 2  | (14 << WidthOffset),
        
        Executed =  3 | (26 << WidthOffset)
    }

    public enum TestCaseStatus : byte
    {
        Failed = 0,

        Passed = 1
    }

    /// <summary>
    /// Describes the outcome of a test case
    /// </summary>
    public readonly struct TestCaseRecord : ITabular<F,R>
    {        
        public readonly string Case;

        public readonly TestCaseStatus Status;

        public readonly Duration Duration;

        public readonly DateTime Executed;

        public static TestCaseRecord Define(string name, bool succeeded, Duration duration)
            => new TestCaseRecord(name, succeeded, duration);
        
        TestCaseRecord(string name, bool succeeded, Duration duration)
        {
            this.Case = name;
            this.Status = succeeded ? TestCaseStatus.Passed : TestCaseStatus.Failed;
            this.Duration = duration;
            this.Executed = DateTime.Now;
        }

        public string DelimitedText(char delimiter)
        {
            var dst = Tabular.FieldFormatter<F>(delimiter);
            dst.Delimit(F.Case, Case);
            dst.Delimit(F.Status, Status);
            dst.Delimit(F.Duration, Duration);            
            dst.Delimit(F.Executed, Executed);
            return dst.ToString();
        }
    }
}