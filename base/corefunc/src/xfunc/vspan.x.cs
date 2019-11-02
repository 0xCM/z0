//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.InteropServices;    
    
    using static zfunc;    

    public static class VSpanX
    {
        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline)]
        public static Span<T> ToSpan<T>(this Vector128<T> src)
            where T : unmanaged            
        {
            var dst = BlockedSpan.AllocBlock<T>(n128);
            gcpu.vstore(src, ref dst.Head);
            return dst.Unblocked;
        }


        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline)]
        public static Span<T> ToSpan<T>(this Vector256<T> src)
            where T : unmanaged            
        {
            var dst = BlockedSpan.AllocBlock<T>(n256);
            gcpu.vstore(src, ref dst.Head);
            return dst.Unblocked;
        }

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline)]
        public static Span128<T> ToBlockedSpan<T>(this Vector128<T> src)
            where T : unmanaged            
        {
            var dst = BlockedSpan.AllocBlock<T>(n128);
            gcpu.vstore(src, ref dst.Head);
            return dst;
        }                       

        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(NotInline)]
        public static Span256<T> ToBlockedSpan<T>(this Vector256<T> src)
            where T : unmanaged            
        {
            var dst = BlockedSpan.AllocBlock<T>(n256);
            gcpu.vstore(src, ref dst.Head);
            return dst;
        }                       



    }

}
