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

    public static partial class XCmd
    {
        public static CmdId Id<T>(this T spec)
            where T : struct, ICmdSpec<T>
                => Cmd.id<T>();
    }
}