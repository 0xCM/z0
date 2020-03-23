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
    public interface IAppContext : IContext
    {        
        IAppPaths Paths 
            => AppPathProvider.Create(Owner, Env.Current.LogDir);  

        IAppSettings Settings
            => AppSettings.Empty;                       
    }
}