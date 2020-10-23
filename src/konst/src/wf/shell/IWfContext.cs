//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public readonly struct TestLogPaths : ITestLogPaths
    {

    }

    public interface IWfContext : ITextual
    {
        IApiParts ApiParts
             => WfShell.parts();

        CorrelationToken Ct
            => z.correlate(Controller.Id);

        IWfPaths Paths
            => WfShell.paths();

        ITestLogPaths TestLogPaths
            => new TestLogPaths();

        IJsonSettings Settings
            => JsonSettings.Load(Paths.AppConfigPath);

        string[] Args
             => Environment.GetCommandLineArgs();

        string AppName
            => Controller.Name;

        string ITextual.Format()
            => AppName;

        WfController Controller
            => Assembly.GetEntryAssembly();
    }
}
