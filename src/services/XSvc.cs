//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Svc = Z0;

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static ApiResProvider ApiResProvider(this IWfRuntime wf)
            => Svc.ApiResProvider.create(wf);

        [Op]
        public static AssetServices Assets(this IWfRuntime wf)
            => AssetServices.create(wf);

        [Op]
        public static CharMapper CharMapper(this IServiceContext context)
            => Svc.CharMapper.create(context);

        [Op]
        public static Symbolism Symbolism(this IWfRuntime wf)
            => Svc.Symbolism.create(wf);

        [Op]
        public static ApiHex ApiHex(this IWfRuntime wf)
            => Svc.ApiHex.create(wf);
    }
}