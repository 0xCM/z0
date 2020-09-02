//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// Characterizes a stateful shared execution environment with a parametric configuration
    /// </summary>
    /// <typeparam name="C">The configuration type</typeparam>
    public interface IContext<C> : IContext
    {
        C Config {get;}
    }

    public interface IApiContext : IShellContext
    {
        IApiSet Api {get;}

        IPart[] Parts
            => Api.Parts;

        PartId[] PartIdList
            => Api.Parts.Select(x => x.Id);

        Assembly[] Components
            => Api.Components;

    }

    public interface IShellContext : IContext, ITextual
    {
        CorrelationToken Ct
            => z.correlate(Control.Id());

        IShellPaths AppPaths
            => Z0.ShellPaths.Default;

        ISettings Settings
            => SettingValues.Load(AppPaths.AppConfigPath);

        FS.FolderPath CaptureRoot
            => FS.dir((AppPaths.LogRoot + FolderName.Define("capture/artifacts")).Name);

        string[] Args
             => Environment.GetCommandLineArgs();

        string ShellName
            => Control.GetSimpleName();

        string ITextual.Format()
            => ShellName;

        Assembly Control
            => Assembly.GetEntryAssembly();
    }
}
