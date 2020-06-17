//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;

    public static class ServiceFactory
    {
        public static ICheckSVF<T> CheckSVF<T>(this ITestContext context)
            where T : unmanaged
             => Z0.CheckSVF<T>.Create(context);

        public static ICheckSVF CheckSVF(this ITestContext context)
            => Z0.CheckSVF.Create(context);
    }
}