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
        /// Takes a value out of a box
        /// </summary>
        /// <param name="src">The boxed value</param>
        /// <typeparam name="T">The boxed type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T unbox<T>(object src)
            where T : struct
                => ref memory.unbox<T>(src);
    }
}