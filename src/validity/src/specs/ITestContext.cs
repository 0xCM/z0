//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITestContext : IAppMsgContext, IServiceAllocation, IPolyrandProvider, ITestService, ITestQueue,
        IShellContext, TClocked, TCheckAction, TCheckOptions, TTestCaseIdentity, TValidator
    {
        bool DiagnosticMode {get;}
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