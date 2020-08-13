//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Reifies an app environment service with the default implementation
    /// </summary>
    [ApiHost]
    public readonly struct AppBase : IAppBase
    {
        public static IAppBase Default => default(AppBase);

        [Op]
        public static AppPathSettings paths()
            => AppPathSettings.create();
    }
}