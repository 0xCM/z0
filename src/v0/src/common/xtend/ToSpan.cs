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
    
    using static Konst;
    using static V0;

    partial class XTend
    {
        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vector128<T> src)
            where T : unmanaged            
                => vspan(src);

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vector256<T> src)
            where T : unmanaged            
                => vspan(src);

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vector512<T> src)
            where T : unmanaged            
                => vspan(src);
    }
}