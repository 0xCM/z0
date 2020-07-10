//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a context that provides access to application configuration data
    /// </summary>
    public interface TAppEnv : IContext
    {
        TAppPaths AppPaths             
            => Z0.AppPaths.Default;

        IAppSettings Settings 
            => AppSettings.Load(AppPaths.AppConfigPath);
    }
}