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

        IShellPaths Paths
            => Z0.ShellPaths.Default;

        IJsonSettings Settings
            => JsonSettings.Load(Paths.AppConfigPath);

        FS.FolderPath CaptureRoot
            => FS.dir((Paths.LogRoot + FolderName.Define("capture/artifacts")).Name);

        string[] Args
             => Environment.GetCommandLineArgs();

        string ShellName
            => Control.GetSimpleName();

        string ITextual.Format()
            => ShellName;

        Assembly Control
            => Assembly.GetEntryAssembly();
    }

    public interface IShellContext<C> : IShellContext, IStateful<C>
    {

    }
}
