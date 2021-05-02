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

    partial struct gcpu
    {
        /// <summary>
        /// Deposits vector content to a stack-allocated data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock128<T> spanblock<T>(Vector128<T> src)
            where T : unmanaged
        {
            var w = w128;
            var stack = ByteBlocks.block(n16);
            ref var dst = ref ByteBlocks.first<T>(ref stack);
            gcpu.vstore(src, ref dst);
            return SpanBlocks.load(w, ref dst);
        }

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock256<T> spanblock<T>(Vector256<T> src)
            where T : unmanaged
        {
            var w = w256;
            var stack = ByteBlocks.block(n32);
            ref var dst = ref ByteBlocks.first<T>(ref stack);
            gcpu.vstore(src, ref dst);
            return SpanBlocks.load(w, ref dst);
        }

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SpanBlock512<T> spanblock<T>(Vector512<T> src)
            where T : unmanaged
        {
            var w = w512;
            var stack = ByteBlocks.block(n64);
            ref var dst = ref ByteBlocks.first<T>(ref stack);
            gcpu.vstore(src, ref dst);
            return SpanBlocks.load(w, ref dst);
        }
    }
}