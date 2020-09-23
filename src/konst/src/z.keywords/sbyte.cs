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
        /// Converts a <see cref='bool'/> to a <see cref='sbyte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe sbyte @sbyte(bool src)
            => (*((sbyte*)(&src))); 

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe sbyte @sbyte<T>(T src)
            where T : unmanaged             
                => *((sbyte*)(&src));
    }
}