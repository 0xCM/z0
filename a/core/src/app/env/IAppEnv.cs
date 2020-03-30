//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAppEnv : IContext
    {
        IAppPaths Paths {get;}      

        IAppSettings Settings {get;}   
    }
}