//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct z
    {
        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static Span<T> vspan<T>(Vector128<T> src)
            where T : unmanaged
        {
            var dst = BufferBlocks.alloc<T>(w128);
            z.vsave(src, ref dst.Head);
            return dst.Data;
        }

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static Span<T> vspan<T>(Vector256<T> src)
            where T : unmanaged
        {
            var dst = BufferBlocks.alloc<T>(w256);
            z.vsave(src, ref dst.Head);
            return dst.Data;
        }

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static Span<T> vspan<T>(Vector512<T> src)
            where T : unmanaged
        {
            var dst = BufferBlocks.alloc<T>(w512);
            z.vsave(src, ref dst.Head);
            return dst.Data;
        }
    }
}