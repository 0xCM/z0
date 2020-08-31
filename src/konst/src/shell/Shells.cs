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
    public readonly struct Shells : IShellContext
    {
        public static IShellContext Default => default(Shells);

        [Op]
        public static PathSettings paths()
            => PathSettings.create();
    }
}