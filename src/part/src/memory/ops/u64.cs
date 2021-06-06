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
        /// Presents a <see cref='bit'/> as a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong u64(bit src)
            => *((byte*)(&src));

        /// <summary>
        /// Presents a <see cref='bool'/> as a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong u64(bool src)
            => *((byte*)(&src));

        /// <summary>
        /// Converts a <see cref='double'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong u64(double src)
            => (*((ulong*)(&src)));

        /// <summary>
        /// Converts a <see cref='decimal'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong u64(decimal src)
            => (*((ulong*)(&src)));

        /// <summary>
        /// Presents a T-references as a <see cref='ulong'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong u64<T>(in T src)
            => ref @as<T,ulong>(src);

        /// <summary>
        /// Adds a <see cref='ulong'/> measured offset to a parametric reference and presents the resulting cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The offset count, measured in bytes</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong u64<T>(in T src, int offset)
            => ref add(@as<T,ulong>(src), offset);

        /// <summary>
        /// Reads 8 bytes or less from the source
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ulong u64(ReadOnlySpan<byte> src)
            => has(src, default(N8)) ? first(recover<ulong>(slice(src,0,8))) : u32(src);
    }
}