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

    [ApiHost(ApiNames.XAlG)]
    public static partial class XAlg
    {
         const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static void Run<H,I>(this HostedLoop<H,I> runnable)
            where I : unmanaged
            where H : struct, ILoopHost<H,I>
                => AlG.run(runnable);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void Run1<I>(this HostedLoop<Accrue<I>,I> runnable)
            where I : unmanaged
                => AlG.run(runnable);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void Run2<I>(this HostedLoop<Accrue<I>,I> runnable)
            where I : unmanaged
                => AlG.run2(runnable);
    }
}