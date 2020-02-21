//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface ITestResultSink
    {
        TestCaseRecord ReportOutcome(string casename, bool succeeded, TimeSpan duration);
    }
}