//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static AppServiceCache Services(this IWfRuntime src)
            => Z0.AppServiceCache.create(src);
    }
}