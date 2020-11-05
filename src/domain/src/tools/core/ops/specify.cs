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

    partial struct Tooling
    {
        [MethodImpl(Inline), Op]
        public static string format(in ToolOption src, char specifier)
            => string.Format("{0}{1}{2}", src.Name, specifier, src.Value);


    }
}