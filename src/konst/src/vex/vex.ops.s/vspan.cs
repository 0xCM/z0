//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct z
    {
        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, Closures(Closure)]
        public static Span<T> vspan<T>(Vector128<T> src)
            where T : unmanaged
                => vspan2(src);

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, Closures(Closure)]
        public static Span<T> vspan<T>(Vector256<T> src)
            where T : unmanaged
                => vspan2(src);

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, Closures(Closure)]
        public static Span<T> vspan<T>(Vector512<T> src)
            where T : unmanaged
                => vspan2(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        static Span<T> vspan2<T>(Vector128<T> src)
            where T : unmanaged
        {
            var w = w128;
            var dst = vinit<T>(w);
            ref var storage = ref vfirst(dst);
            vsave(src, ref storage);
            return cover(storage, cpu.vcount<T>(w));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        static Span<T> vspan2<T>(Vector256<T> src)
            where T : unmanaged
        {
            var w = w256;
            var dst = vinit<T>(w);
            ref var storage = ref vfirst(dst);
            vsave(src, ref storage);
            return cover(storage, cpu.vcount<T>(w));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        static Span<T> vspan2<T>(Vector512<T> src)
            where T : unmanaged
        {
            var w = w512;
            var dst = vinit<T>(w);
            ref var storage = ref vfirst(dst);
            vsave(src, ref storage);
            return cover(storage, cpu.vcount<T>(w));
        }
    }
}