//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// A context of everything and yet to everyting nothing
    /// </summary>
    public interface IAppContext : IAppEnv
    {        
        IAppPaths IAppEnv.AppPaths 
            => IAppPaths.Default;

        IAppSettings IAppEnv.Settings
            => AppSettings.Empty;                       
    }
}