//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class RootServices
    {
        public static ILogDevice OpenLogDevice(this IContext context, FilePath target, string devname = null,  bool append = false, bool display = false)
            => LogDevice.Open(context, target, devname, append, display);
    }

}