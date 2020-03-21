//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    using System;
    using System.Collections.Generic;

    public interface ITestContext : IDisposable, IPolyrandContext, IAppMsgSink
    {
        void ReportBenchmark(string name, long opcount, TimeSpan duration);        

        void ReportOutcome(string casename, bool succeeded, TimeSpan duration);

        ITestConfig Config {get;}

        string CaseName(IFunc f);

        Type HostType {get;}
    }

}