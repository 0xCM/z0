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
        /// Converts a <see cref='bool'/> to a <see cref='long'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe long @long(bool src)
            => (*((byte*)(&src)));

        [MethodImpl(Inline), Op, Closures(Numeric64k)]
        public static unsafe long @long<T>(T src)
            where T : unmanaged
                => *((long*)(&src));
    }
}