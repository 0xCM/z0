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

    public interface IShellContext : IContext, ITextual
    {
        IShellPaths AppPaths
            => Z0.ShellPaths.Default;

        ISettings Settings
            => SettingValues.Load(AppPaths.AppConfigPath);

        FS.FolderPath CaptureRoot
            => FS.dir((AppPaths.LogRoot + FolderName.Define("capture/artifacts")).Name);
        IApiSet Api
            => ApiQuery.apiset();

        string[] Args
             => sys.empty<string>();

        string ShellName
            => Root.GetSimpleName();

        string ITextual.Format()
            => ShellName;

        IPart[] Parts
            => Api.Parts;

        Assembly[] Components
            => Api.Components;

        Assembly Root
            => Assembly.GetEntryAssembly();
    }

    public interface IShellContext<C> : IContext<C>, IShellContext
    {

    }
}