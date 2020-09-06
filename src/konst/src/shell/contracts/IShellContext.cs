//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IShellContext : ITextual
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
