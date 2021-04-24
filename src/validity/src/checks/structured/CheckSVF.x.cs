//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public static partial class XTend
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ICheckSVF<T> CheckSVF<T>(this ITestContext context)
            where T : unmanaged
                => new CheckSVF<T>(context);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ICheckSVF CheckSVF(this ITestContext context)
            => new CheckSVF(context);
    }
}