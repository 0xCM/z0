//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct UI
    {
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
        public static ref S edit<S>(in uint8T src)
            where S : unmanaged
                => ref @as<uint8T,S>(src);
    }
}