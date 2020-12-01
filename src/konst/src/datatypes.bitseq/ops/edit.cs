//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct BitSeq
    {
        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='Z0.uint4'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint5 edit<S>(in S src, W5 dst)
            where S : unmanaged
                => ref @as<S,uint5>(src);

        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='Z0.uint5'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in uint5 src)
            where S : unmanaged
                => ref @as<uint5,S>(src);

        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='Z0.uint6'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint6 edit<S>(in S src, W6 dst)
            where S : unmanaged
                => ref @as<S,uint6>(src);

        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='Z0.uint7'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint7 edit<S>(in S src, W7 dst)
            where S : unmanaged
                => ref @as<S,uint7>(src);

        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='Z0.uint8T'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint8T cast<S>(in S src, W8 dst)
            where S : unmanaged
                => ref @as<S,uint8T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in uint1 src)
            where S : unmanaged
                => ref @as<uint1,S>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in uint2 src)
            where S : unmanaged
                => ref @as<uint2,S>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in uint3 src)
            where S : unmanaged
                => ref @as<uint3,S>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in uint4 src)
            where S : unmanaged
                => ref @as<uint4,S>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in uint6 src)
            where S : unmanaged
                => ref @as<uint6,S>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in uint7 src)
            where S : unmanaged
                => ref @as<uint7,S>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in uint8T src)
            where S : unmanaged
                => ref @as<uint8T,S>(src);
    }
}