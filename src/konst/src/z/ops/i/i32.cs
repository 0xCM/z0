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
        public static unsafe int i32(bool on)
            => *((sbyte*)(&on));

        /// <summary>
        /// Presents a T-references as a <see cref='int'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref int i32<T>(in T src)
            => ref @as<T,int>(src);   
    }
}