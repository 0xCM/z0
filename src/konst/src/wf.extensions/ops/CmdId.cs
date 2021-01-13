//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    partial class XWf
    {
        public static CmdId CmdId<T>(this T spec)
            where T : struct, ICmdSpec<T>
                => Cmd.id<T>();
    }
}