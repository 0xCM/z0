//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Root;
    using static Nats;

    partial class vgeneric
    {
        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline), Op, NumericClosures(NumericKind.All)]
        public static Span<T> span<T>(Vector128<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(n128);
            vstore(src, ref dst.Head);
            return dst.Data;
        }

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline), Op, NumericClosures(NumericKind.All)]
        public static Span<T> span<T>(Vector256<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(n256);
            vstore(src, ref dst.Head);
            return dst.Data;
        }

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline), Op, NumericClosures(NumericKind.All)]
        public static Span<T> span<T>(Vector512<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(n512);
            vstore(src, ref dst.Head);
            return dst.Data;
        }

    }
}