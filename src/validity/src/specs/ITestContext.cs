//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITestContext : IAppMsgContext, IDisposable, IPolyrandProvider, ITestService, ITestQueue, TClocked, TCheckAction, ICheckSettings, ITestCaseIdentity, IValidator
    {
        bool DiagnosticMode {get;}

        ITestRunPaths TestPaths {get;}
    }

    public interface ITestContext<U> : ITestContext
        where U : ITestContext<U>
    {
        Type IValidator.HostType
            => typeof(U);
    }

    public interface IExplicitTest : IUnitTest, IExecutable
    {

    }
}