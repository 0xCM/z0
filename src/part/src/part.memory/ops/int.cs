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
        /// Forcefully coerces a <see cref='bool'/> to a <see cref='int'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe int @int(bool src)
            => (*((byte*)(&src)));

        /// <summary>
        /// Forcefully coerces a <see cref='float'/> to a <see cref='int'/>
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