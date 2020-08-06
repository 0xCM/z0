//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IAppBase : IContext
    {
        string AppName 
            => Assembly.GetEntryAssembly().GetSimpleName(); 

        IAppPaths AppPaths             
            => Z0.AppPaths.Default;

        IAppSettings Settings 
            => AppSettings.Load(AppPaths.AppConfigPath);
    }

    public interface IAppBase<F> : IAppBase
        where F : IAppBase<F>
    {

    }
}