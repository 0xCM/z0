//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static As;

    partial class gmath
    {
        /// <summary>
        /// If the source value is nonzero, it is returned unmolested; othwewise, -1 is returned
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T zclear<T>(T src)
            where T : unmanaged
                => sub(src, Cast.to<T>((uint)eq(src,zero<T>())));
    }
}