//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Asm;

    using static Root;

    using Svc = Z0.Asm;

    public static class XSvc
    {
       public static AsmWorkspace AsmWorkspace(this IEnvProvider provider)
            => Svc.AsmWorkspace.create(provider.Env.AsmWorkspace);
    }
}