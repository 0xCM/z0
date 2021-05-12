//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Numeric
    {
        /// <summary>
        /// Returns 1 if <typeparamref name='T'/> is a signed integral type and 0 otherwise
        /// </summary>
        /// <typeparam name="T">The test type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bit signed<T>()
            where T : unmanaged
                => typeof(T) == typeof(sbyte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long);
    }
}