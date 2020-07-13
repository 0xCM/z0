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
        /// Converts a <see cref='bool'/> to a <see cref='ushort'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ushort @ushort(bool src)
            => (*((byte*)(&src))); 

        [MethodImpl(Inline), Op, Closures(Numeric16x32x64k)]
        public static unsafe ushort @ushort<T>(T src)
            where T : unmanaged             
                => *((ushort*)(&src));
    }
}