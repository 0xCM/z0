//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IValidationContext : ITestContext //IPolyrandProvider, IAppMsgSink, IAppContext
    {
        //void ReportOutcome(string casename, bool succeeded, TimeSpan duration, AppMsg msg = null);

        //Type HostType {get;}

        string ITestContext.CaseName(ISFuncApi f)
            => Validity.testcase(HostType, f);
    }
}