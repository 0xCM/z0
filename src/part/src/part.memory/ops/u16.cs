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
    }
}