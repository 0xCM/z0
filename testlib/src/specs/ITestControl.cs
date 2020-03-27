//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    public interface ITestControl : IAppMsgQueue
    {
        void Configure(ITestConfig config);

        IEnumerable<BenchmarkRecord> TakeBenchmarks();

        IEnumerable<TestCaseRecord> TakeOutcomes();
    }    
}