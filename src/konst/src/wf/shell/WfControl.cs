//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.WfControl, true)]
    public readonly struct WfControl
    {
        [MethodImpl(Inline), Op]
        public static WfController controller(Assembly src)
            => new WfController(src);

        [MethodImpl(Inline)]
        public static WfController<P> controller<P>()
            where P : IPart<P>, new()
                => default;

        [MethodImpl(Inline)]
        public static WfFunc<H> func<H>([CallerMemberName] string name = null)
            where H : struct, IWfStep<H>
                => new WfFunc<H>(name);

        [MethodImpl(Inline)]
        public static WfFunc<H,T> func<H,T>(H host, T t, [CallerMemberName] string name = null)
            where H : struct, IWfStep<H>
                => new WfFunc<H,T>(name);

        [MethodImpl(Inline)]
        public static WfFunc<H,T> func<H,T>([CallerMemberName] string name = null)
            where H : struct, IWfStep<H>
                => new WfFunc<H,T>(name);

        [MethodImpl(Inline), Op]
        public static WfShellHost host(IWfShell wf, WfHost host)
            => (wf,host);

        [MethodImpl(Inline)]
        public static WfShellHost<H> host<H>(IWfShell wf)
            where H : IWfHost<H>, new()
                => new WfShellHost<H>(wf,new H());
    }
}