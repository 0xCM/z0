//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using Z0.Asm;

    using Svc = Z0.Asm;

    public static partial class XSvc
    {
        public static AsmWorkspace AsmWorkspace(this IEnvContext context)
            => Svc.AsmWorkspace.create(context.Env.AsmWorkspace);
    }
}