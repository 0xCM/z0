//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Reifies an app environment service with the default implementation
    /// </summary>
    public readonly struct AppEnv : TAppEnv
    {
        public static TAppEnv Default => default(AppEnv);
    }
}