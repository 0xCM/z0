//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class WfRuntime
    {
        [Op]
        internal static IAppService service(Type host, IWfRuntime wf)
        {
            var t = typeof(AppService<>).MakeGenericType(host);
            var m = t.GetMethod("create");
            return (IAppService)m.Invoke(null, new object[]{wf});
        }

        [MethodImpl(Inline)]
        internal static H service<H>(IWfRuntime wf)
            where H : AppService<H>, new()
                => AppService<H>.create(wf);
    }
}