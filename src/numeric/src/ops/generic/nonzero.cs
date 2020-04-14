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

    using static Seed;
    using static Memories;

    partial class Numeric
    {
        /// <summary>
        /// Manufactures a numeric proxy defined over the punctured domain T / {0}. If a
        /// zero value is supplied, it is replaced with -1
        /// </summary>
        /// <param name="value">The nonzero value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(NumericKind.All)]
        public static nonzero<T> nonzero<T>(T value)
            where T : unmanaged
                => new nonzero<T>(value);

        /// <summary>
        /// If the source value is nonzero, it is returned unmolested; othwewise, -1 is returned
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T zclear<T>(T src)
            where T : unmanaged
                => sub(src, convert<T>((uint)eq(src,zero<T>())));
    }
}