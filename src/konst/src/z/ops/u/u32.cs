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
        /// Converts a <see cref='bool'/> to a <see cref='uint'/>
        /// </summary>
        /// <param name="on">The source state</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint u32(bool on)
            => *((byte*)(&on));

        /// <summary>
        /// Presents a parametric references as a <see cref='uint'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint u32<T>(in T src)
            => ref @as<T,uint>(src);
    }
}