//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITestContext : IAppMsgContext, IDisposable, IPolyrandProvider, ITestService, ITestQueue, TClocked, TCheckAction, TCheckOptions, ITestCaseIdentity, TValidator
    {
        bool DiagnosticMode {get;}

        ITestLogPaths TestLogPaths {get;}
    }

    public interface ITestContext<U> : ITestContext
        where U : ITestContext<U>
    {
        Type TValidator.HostType
            => typeof(U);
    }

    public interface IExplicitTest : IUnitTest, IExecutable
    {

    }
}