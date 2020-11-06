//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IWfContext : ITextual
    {
        IWfPaths Paths
            => WfShell.paths();

        IJsonSettings Settings
            => JsonSettings.Load(Paths.AppConfigPath);

        IApiParts ApiParts
             => WfShell.parts();

        CorrelationToken Ct
            => z.correlate(Controller.Id);

        ITestLogPaths TestLogPaths
            => new TestLogPaths();

        AppArgs Args
             => Environment.GetCommandLineArgs();

        string AppName
            => Controller.Name;

        string ITextual.Format()
            => AppName;

        WfController Controller
            => Assembly.GetEntryAssembly();
    }
}
