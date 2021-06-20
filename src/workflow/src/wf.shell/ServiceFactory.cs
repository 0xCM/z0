//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct ServiceFactory
    {
        [Op]
        public static IAppService appsvc(Type host, IWfRuntime wf)
        {
            var t = typeof(AppService<>).MakeGenericType(host);
            var m = t.GetMethod("create");
            return (IAppService)m.Invoke(null, new object[]{wf});
        }

        [MethodImpl(Inline)]
        public static H appsvc<H>(IWfRuntime wf)
            where H : AppService<H>, new()
                => AppService<H>.create(wf);
    }
}