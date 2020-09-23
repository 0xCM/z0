//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Returns a parametric numerick-kind classifier
        /// </summary>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NK<T> nk<T>()
            where T : unmanaged
                => NumericKinds.kind<T>();

        /// <summary>
        /// Determines the source types's numeric kind classifier
        /// </summary>
        /// <param name="t">The type to classify</param>
        [MethodImpl(Inline), Op]
        public static NumericKind nk(Type t)
            => NumericKinds.kind(t);
    }
}