//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IValidationContext : IRngContext, IAppMsgSink
    {
        void ReportOutcome(string casename, bool succeeded, TimeSpan duration, AppMsg msg = null);

        Type HostType {get;}

        string CaseName(ISFuncApi f)
            => TestIdentity.testcase(HostType, f);
    }
}