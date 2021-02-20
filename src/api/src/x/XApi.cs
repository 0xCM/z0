//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public static partial class XApi
    {
        [Op]
        public static IApiServices ApiServices(this IWfShell wf)
            => Z0.ApiServices.create(wf);
    }
}