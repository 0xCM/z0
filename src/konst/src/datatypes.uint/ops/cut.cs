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

    partial struct UI
    {
        /// <summary>
        /// Shears the input to a target width
        /// </summary>
        /// <param name="src">The value to cut</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ref uint1 cut(in byte src, W1 dst)
            => ref @as<byte,uint1>(src);

        /// <summary>
        /// Shears the input to a target width
        /// </summary>
        /// <param name="src">The value to cut</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ref uint2 cut(in byte src, W2 dst)
            => ref @as<byte,uint2>(src);

        /// <summary>
        /// Shears the input to a target width
        /// </summary>
        /// <param name="src">The value to cut</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ref uint3 cut(in byte src, W3 dst)
            => ref @as<byte,uint3>(src);

        /// <summary>
        /// Shears the input to a target width
        /// </summary>
        /// <param name="src">The value to cut</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ref uint4 cut(in byte src, W4 dst)
            => ref @as<byte,uint4>(src);

        /// <summary>
        /// Shears the input to a target width
        /// </summary>
        /// <param name="src">The value to cut</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ref uint5 cut(in byte src, W5 dst)
            => ref @as<byte,uint5>(src);

        /// <summary>
        /// Shears the input to a target width
        /// </summary>
        /// <param name="src">The value to cut</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ref uint6 cut(in byte src, W6 dst)
            => ref @as<byte,uint6>(src);

        /// <summary>
        /// Shears the input to a target width
        /// </summary>
        /// <param name="src">The value to cut</param>
        /// <param name="dst">The target width</param>
        [MethodImpl(Inline), Op]
        public static ref uint7 cut(in byte src, W7 dst)
            => ref @as<byte,uint7>(src);
    }
}