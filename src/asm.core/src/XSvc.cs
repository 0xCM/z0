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
        public static AsmRegSets AsmRegSets(this IServiceContext ctx)
            => Svc.AsmRegSets.create(ctx);

        [Op]
        public static AsmSymbols AsmSymbols(this IServiceContext ctx)
            => Svc.AsmSymbols.create();

        [Op]
        public static AsmEtl AsmEtl(this IServiceContext ctx)
            => Svc.AsmEtl.create(ctx);
    }
}