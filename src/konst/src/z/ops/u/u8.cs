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
        /// Converts a <see cref='bool'/> to a <see cref='byte'/>
        /// </summary>
        /// <param name="on">The source state</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte u8(bool on)
            => *((byte*)(&on));

        /// <summary>
        /// Presents a T-references as a <see cref='byte'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte u8<T>(in T src)
            => ref @as<T,byte>(src);

        /// <summary>
        /// Adds a byte-measured offset to a parametric reference and presents the result as a <see cref='byte'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The offset count, measured in bytes</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte u8<T>(in T src, int offset)
            => ref add(@as<T,byte>(src), offset);
    }
}