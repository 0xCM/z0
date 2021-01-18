//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Clr
    {
        /// <summary>
        /// Queries a specified type for its handle
        /// </summary>
        [MethodImpl(Inline), Op]
        public static IntPtr handle(Type src)
            => sys.handle(src);

        /// <summary>
        /// Queries a parametrically identified type for its handle
        /// </summary>
        /// <typeparam name="T">The type to query</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IntPtr handle<T>()
            => sys.handle<T>();
    }
}