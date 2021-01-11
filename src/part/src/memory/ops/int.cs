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
        /// Presents a <see cref='bool'/> as a <see cref='int'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe int @int(bool src)
            => (*((byte*)(&src)));

        /// <summary>
        /// Presents a <see cref='float'/> value as an <see cref='int'/> value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe int @int(float src)
            => (*((int*)(&src)));

        [MethodImpl(Inline), Op, Closures(Numeric32x64k)]
        public static unsafe int @int<T>(T src)
            where T : unmanaged
                => *((int*)(&src));
    }
}