//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public static partial class XApi
    {
        [Op]
        public static IApiServices ApiServices(this IWfShell wf)
            => Z0.ApiServices.create(wf);
    }
}