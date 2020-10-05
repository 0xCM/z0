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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Ptr<T> next<T>(in Ptr<T> src)
            where T : unmanaged
        {
            ref var dst = ref edit(src);
            dst.P++;
            return ref dst;
        }

        /// <summary>
        /// Advances the source by a uint
        /// </summary>
        /// <param name="src">The source pointer</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr8 next(in Ptr8 src)
        {
            ref var dst = ref edit(src);
            dst.P++;
            return ref dst;
        }

        /// <summary>
        /// Advances the source by a uint
        /// </summary>
        /// <param name="src">The source pointer</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr16 next(in Ptr16 src)
        {
            ref var dst = ref edit(src);
            dst.P++;
            return ref dst;
        }

        /// <summary>
        /// Advances the source by a uint
        /// </summary>
        /// <param name="src">The source pointer</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr32 next(in Ptr32 src)
        {
            ref var dst = ref edit(src);
            dst.P++;
            return ref dst;
        }

        /// <summary>
        /// Advances the source by a uint
        /// </summary>
        /// <param name="src">The source pointer</param>
        [MethodImpl(Inline), Op]
        public static ref Ptr64 next(in Ptr64 src)
        {
            ref var dst = ref edit(src);
            dst.P++;
            return ref dst;
        }
    }
}