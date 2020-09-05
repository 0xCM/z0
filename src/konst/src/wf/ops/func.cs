//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using D = WfDelegates;

    partial struct Flow
    {

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
    }
}