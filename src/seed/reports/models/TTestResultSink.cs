//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;

    public interface TTestResultSink : IRecordSink<TestCaseRecord>
    {
        void ReportCaseResult(string casename, bool succeeded, TimeSpan duration)
            => Deposit(TestCaseRecord.Define(casename,succeeded,duration));
        
        void ISink<TestCaseRecord>.Deposit(TestCaseRecord src)
            => term.print(src.DelimitedText(Chars.Pipe));
    }
}