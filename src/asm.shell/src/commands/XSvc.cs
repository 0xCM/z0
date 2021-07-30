//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public static class XSvc
    {
        public static AsmEnv AsmEnv(this IServiceContext context)
            => Z0.AsmEnv.create(context);
    }
}