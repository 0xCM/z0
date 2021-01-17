//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XCmd
    {
        public static string Format<C>(this C src)
            where C : struct, ICmdSpec<C>
                => Cmd.format(src);
    }
}