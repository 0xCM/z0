//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using Svc = Z0.Asm;

    [ApiHost]
    public static class XSvc
    {
       [Op]
       public static AsmWorkspace AsmWorkspace(this IEnvProvider provider)
            => Svc.AsmWorkspace.create(provider.Env.AsmWorkspace);

        [Op]
        public static AsmRegGrids AsmRegGrids(this IServiceContext env)
            => Svc.AsmRegGrids.create(env);

        [Op]
        public static AsmSymbols AsmSymbols(this IServiceContext env)
            => Svc.AsmSymbols.create();
    }
}