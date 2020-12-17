//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Takes a value out of a box
        /// </summary>
        /// <param name="src">The boxed value</param>
        /// <typeparam name="T">The boxed type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T unbox<T>(object src)
            where T : struct
                => ref sys.unbox<T>(src);

        [MethodImpl(Inline)]
        public static ref T unbox<T>(Enum src)
            where T : unmanaged, Enum
                => ref sys.unbox<T>(src);
    }
}