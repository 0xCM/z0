//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    partial class Vectors
    {
        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, NumericClosures(NumericKind.All)]
        public static Span<T> span<T>(Vector128<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(w128);
            Vectors.vstore(src, ref dst.Head);
            return dst.Data;
        }

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, NumericClosures(NumericKind.All)]
        public static Span<T> span<T>(Vector256<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(w256);
            Vectors.vstore(src, ref dst.Head);
            return dst.Data;
        }

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, NumericClosures(NumericKind.All)]
        public static Span<T> span<T>(Vector512<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(w512);
            Vectors.vstore(src, ref dst.Head);
            return dst.Data;
        }

 
    }
}