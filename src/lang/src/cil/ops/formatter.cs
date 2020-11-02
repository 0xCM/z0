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

    partial struct Cil
    {
        [MethodImpl(Inline), Op]
        public static CilFunctionFormatter formatter()
            => formatter(CilFormatConfig.Default);

        [MethodImpl(Inline), Op]
        public static CilFunctionFormatter formatter(CilFormatConfig config)
            => new CilFunctionFormatter(config);
    }
}