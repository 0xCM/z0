//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IShellBase : ITextual
    {
        string ShellName
            => Assembly.GetEntryAssembly().GetSimpleName();

        IShellPaths AppPaths
            => Z0.ShellPaths.Default;

        ISettings Settings
            => SettingValues.Load(AppPaths.AppConfigPath);

        string ITextual.Format()
            => ShellName;
    }
}