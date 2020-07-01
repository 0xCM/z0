//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        /// <summary>
        /// Returns generic 1 for a primal source type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T one<T>(T t = default)
            where T : unmanaged
                => NumericLiterals.one<T>();
    }
}