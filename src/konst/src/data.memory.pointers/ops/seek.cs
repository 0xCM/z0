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

    unsafe partial struct Pointers
    {
        /// <summary>
        /// Advances the source by a T-measured offset
        /// </summary>
        /// <param name="src">The source pointer</param>
        /// <param name="count">The number of T-elements to advance</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Ptr<T> seek<T>(in Ptr<T> src, uint count)
            where T : unmanaged
        {
            ref var dst = ref edit(src);
            dst.P += count;
            return ref dst;
        }

        /// <summary>
        /// Advances the source by a specified count
        /// </summary>
        /// <param name="src">The source pointer</param>
        /// <param name="count">The number of elements to skip</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr8 seek(in Ptr8 src, uint count)
        {
            ref var dst = ref edit(src);
            dst.P += count;
            return ref dst;
        }

        /// <summary>
        /// Advances the source by a uint
        /// </summary>
        /// <param name="src">The source pointer</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr16 seek(in Ptr16 src, uint count)
        {
            ref var dst = ref edit(src);
            dst.P += count;
            return ref dst;
        }

        /// <summary>
        /// Advances the source by a uint
        /// </summary>
        /// <param name="src">The source pointer</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr32 seek(in Ptr32 src, uint count)
        {
            ref var dst = ref z.edit(src);
            dst.P += count;
            return ref dst;
        }

        /// <summary>
        /// Advances the source by a uint
        /// </summary>
        /// <param name="src">The source pointer</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr64 seek(in Ptr64 src, uint count)
        {
            ref var dst = ref z.edit(src);
            dst.P += count;
            return ref dst;
        }
    }
}