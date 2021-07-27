//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    public static class XSvc
    {
        public static AsmEnv AsmEnv(this IServiceContext context)
            => Z0.AsmEnv.create(context);
    }
}