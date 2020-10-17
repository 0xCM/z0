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
        IApiParts ApiParts
             => WfShell.parts();

        CorrelationToken Ct
            => z.correlate(Control.Id());

        IWfPaths Paths
            => WfPaths.create();

        IJsonSettings Settings
            => JsonSettings.Load(Paths.AppConfigPath);

        string[] Args
             => Environment.GetCommandLineArgs();

        string AppName
            => Control.GetSimpleName();

        string ITextual.Format()
            => AppName;

        Assembly Control
            => Assembly.GetEntryAssembly();
    }

    public interface IWfContext<C> : IWfContext, IStateful<C>
    {

    }
}
