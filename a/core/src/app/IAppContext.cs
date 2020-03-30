//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// A context of everything and yet to everyting nothing
    /// </summary>
    public interface IAppContext : IAppEnv
    {        
        IAppPaths IAppEnv.Paths 
            => AppPathProvider.Create(Owner, Env.Current.LogDir);  

        IAppSettings IAppEnv.Settings
            => AppSettings.Empty;                       
    }
}