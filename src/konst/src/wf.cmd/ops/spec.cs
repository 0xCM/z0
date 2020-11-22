//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        public static CmdSpec<T> spec<T>(T src)
            where T : struct, ICmdSpec<T>
                => new CmdSpec<T>(args(src));
    }
}