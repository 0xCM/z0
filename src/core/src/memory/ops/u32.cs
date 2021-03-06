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
        // [MethodImpl(Inline), Op]
        // public static unsafe uint u32(bit src)
        //     => *((byte*)(&src));

        /// <summary>
        /// Presents a <see cref='bool'/> as a <see cref='uint'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint u32(bool src)
            => *((byte*)(&src));

        /// <summary>
        /// Presents a parametric references as a <see cref='uint'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint u32<T>(in T src)
            => ref @as<T,uint>(src);

        /// <summary>
        /// Adds a <see cref='uint'/> measured offset to a parametric reference and presents the resulting cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The offset count, measured in bytes</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint u32<T>(in T src, int offset)
            => ref add(@as<T,uint>(src), offset);

        /// <summary>
        /// Reads 4 bytes or less from the source
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static uint u32(ReadOnlySpan<byte> src)
            => has(src, default(N4)) ? first(recover<uint>(slice(src,0,4))) : u16(src);
    }
}