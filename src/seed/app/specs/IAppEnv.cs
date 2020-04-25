//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Reifies an app environment service with the default implementation
    /// </summary>
    public readonly struct AppEnv : IAppEnv
    {
        public static IAppEnv Default => default(AppEnv);
    }
    
    /// <summary>
    /// Characterizes a context that provides access to application configuration data
    /// </summary>
    public interface IAppEnv : IContext
    {
        IAppPaths AppPaths             
            => IAppPaths.Default;

        IAppSettings Settings 
            => AppSettings.Empty;
    }
}