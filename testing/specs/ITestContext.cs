//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface ITestContext : IDisposable, IRngContext, IAppMsgContext, ITestResultSink, ITestResultSource, IBenchResultSink, IBenchResultSource
    {
        ITestConfig Config {get;}

        void Configure(ITestConfig config);

        bool Enabled {get;}

        string CaseName(IFunc f);

        string CaseName(string fullname);

        int RepCount {get;}
    }

    public interface IExternalTestContext : IRngContext, IAppMsgContext
    {

    }

    public interface ITestContext<C> : ITestContext
    {

    }

}