//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        internal static Span<T> ToSpan<T>(this Vector128<T> src)
            where T : unmanaged            
        {
            var dst = DataBlocks.single<T>(n128);
            vstore(src, ref dst.Head);
            return dst.Data;
        }

        /// <summary>
        /// Allocates and deposits vector content to a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline)]
        internal static Span<T> ToSpan<T>(this Vector256<T> src)
            where T : unmanaged            
        {
            var dst = DataBlocks.single<T>(n256);
            vstore(src, ref dst.Head);
            return dst.Data;
        }

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline)]
        internal static Block128<T> ToBlock<T>(this Vector128<T> src)
            where T : unmanaged            
        {
            var dst = DataBlocks.single<T>(n128);
            vstore(src, ref dst.Head);
            return dst;
        }                       

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(NotInline)]
        internal static Block256<T> ToBlock<T>(this Vector256<T> src)
            where T : unmanaged            
        {
            var dst = DataBlocks.single<T>(n256);
            vstore(src, ref dst.Head);
            return dst;
        }            

        /// <summary>
        /// Determines whether any elements of the source match the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="target">The target value to match</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this ReadOnlySpan<T> src, T target)        
            where T : unmanaged
                => src.BinarySearch(target, PrimalComparer.Get<T>()) >= 0;
    }
}
