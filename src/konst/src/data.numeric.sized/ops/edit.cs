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

    partial struct Sized
    {
        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='Z0.uint1'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint1 edit<S>(in S src, W1 dst)
            where S : unmanaged
                => ref @as<S,uint1>(src);

        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='Z0.uint1'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint2 edit<S>(in S src, W2 dst)
            where S : unmanaged
                => ref @as<S,uint2>(src);

        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='Z0.uint2'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint3 edit<S>(in S src, W3 dst)
            where S : unmanaged
                => ref @as<S,uint3>(src);

        /// <summary>
        /// Reinterprets an input reference as as a mutable <see cref='Z0.uint3'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint4 edit<S>(in S src, W4 dst)
            where S : unmanaged
                => ref @as<S,uint4>(src);

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
        /// Reinterprets an input reference as a mutable <see cref='Z0.octet'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref octet cast<S>(in S src, W8 dst)
            where S : unmanaged
                => ref @as<S,octet>(src);

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
        public static ref S edit<S>(in octet src)
            where S : unmanaged
                => ref @as<octet,S>(src);
    }
}