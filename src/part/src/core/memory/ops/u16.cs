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
        /// Presents a <see cref='bool'/> as a <see cref='ushort'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ushort u16(bool src)
            => *((byte*)(&src));

        /// <summary>
        /// Presents a <see cref='bit'/> as a <see cref='ushort'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ushort u16(bit src)
            => *((byte*)(&src));

        /// <summary>
        /// Presents a T-reference as a <see cref='ushort'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort u16<T>(in T src)
            => ref @as<T,ushort>(src);

        /// <summary>
        /// Adds a <see cref='ushort'/> measured offset to a parametric reference and presents the resulting as a <see cref='ushort'/> cell reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The offset count, measured in bytes</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort u16<T>(in T src, int offset)
            => ref add(@as<T,ushort>(src), offset);

        /// <summary>
        /// Reads 2 bytes or less from the source
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ushort u16(ReadOnlySpan<byte> src)
            => has(src,default(N2)) ? first(recover<ushort>(slice(src,0,2))) : u8(src);

    }
}