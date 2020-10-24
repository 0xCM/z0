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

        WfSettings WfSettings
            => WfShell.settings(this);

        IJsonSettings Settings
            => JsonSettings.Load(Paths.AppConfigPath);

        IApiParts ApiParts
             => WfShell.parts();

        CorrelationToken Ct
            => z.correlate(Controller.Id);


        ITestLogPaths TestLogPaths
            => new TestLogPaths();

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
