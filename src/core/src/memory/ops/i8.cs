//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Presents a <see cref='bool'/> as a <see cref='sbyte'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe sbyte i8(bool src)
            => *((sbyte*)(&src));

        /// <summary>
        /// Presents a <typeparamref name='T'/> reference as an <see cref='sbyte'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref sbyte i8<T>(in T src)
            => ref @as<T,sbyte>(src);
    }
}