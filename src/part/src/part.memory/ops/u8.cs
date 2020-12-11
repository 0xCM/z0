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
        /// Presents an input <see cref='bit'/> value as a <see cref='byte'/> value
        /// </summary>
        /// <param name="src">The source bit</param>
        [MethodImpl(Inline), Op]
        public static ref byte u8(in bit src)
            => ref memory.@as<bit,byte>(src);

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

        /// <summary>
        /// Converts a <see cref='bool'/> to a <see cref='ushort'/>
        /// </summary>
        /// <param name="on">The source state</param>
        [MethodImpl(Inline), Op]
        public static unsafe ushort u16(bool on)
            => *((byte*)(&on));

        /// <summary>
        /// Presents a T-references as a <see cref='ushort'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort u16<T>(in T src)
            => ref @as<T,ushort>(src);

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

        /// <summary>
        /// Converts a <see cref='bool'/> to a <see cref='ulong'/>
        /// </summary>
        /// <param name="on">The source state</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong u64(bool on)
            => *((byte*)(&on));

        /// <summary>
        /// Presents a T-references as a <see cref='ulong'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong u64<T>(in T src)
            => ref @as<T,ulong>(src);
    }
}