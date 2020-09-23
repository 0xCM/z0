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
        [MethodImpl(Inline), Op]
        public static unsafe long i64(bool on)
            => *((sbyte*)(&on));

        /// <summary>
        /// Presents a T-references as a <see cref='long'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref long i64<T>(in T src)
            => ref @as<T,long>(src);

    }
}