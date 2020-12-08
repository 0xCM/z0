//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Cil
    {
        [MethodImpl(Inline), Op]
        public static FunctionFormatter formatter()
            => formatter(FormatConfig.Default);

        [MethodImpl(Inline), Op]
        public static FunctionFormatter formatter(FormatConfig config)
            => new FunctionFormatter(config);
    }
}