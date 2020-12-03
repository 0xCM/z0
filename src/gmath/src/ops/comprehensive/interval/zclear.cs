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

    partial class gmath
    {
        /// <summary>
        /// If the source value is nonzero, it is returned unmolested; otherwise, -1 is returned
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T zclear<T>(T src)
            where T : unmanaged
                => sub(src, NumericCast.force<T>((uint)eq(src,zero<T>())));
    }
}