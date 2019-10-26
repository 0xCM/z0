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
            vstore(src, ref dst.Head);
            return dst.Unblocked;
        }

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline)]
        public static ref Span128<T> ToSpan<T>(this Vector128<T> src, out Span128<T> dst)
            where T : unmanaged            
        {
            dst = BlockedSpan.AllocBlock<T>(n128);
            vstore(src, ref dst.Head);
            return ref dst;
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
            vstore(src, ref dst.Head);
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
            vstore(src, ref dst.Head);
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
            vstore(src, ref dst.Head);
            return dst;
        }                       

        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(NotInline)]
        public static Span128<T> ToSpan128<T>(this Vec128<T> src)
            where T : unmanaged     
        {
            var dst = BlockedSpan.AllocBlock<T>(n128);
            vstore(src, ref head(dst));
            return dst;
        }                       
        
        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(NotInline)]
        public static Span256<T> ToSpan256<T>(this Vec256<T> src)
            where T : unmanaged            
        {
            var dst = BlockedSpan.AllocBlock<T>(n256);
            vstore(src, ref head(dst));
            return dst;
        }                       

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vec128<T> src)
            where T : unmanaged            
                => src.ToSpan128();

        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vec256<T> src)
            where T : unmanaged            
                => src.ToSpan256();

        /// <summary>
        /// Extracts vector content as a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(NotInline)]
        public static unsafe Span<T> ToSpan<T>(this Vec512<T> src)
            where T : unmanaged        
                => new Span<T>(As.pvoid(ref Unsafe.Add(ref src, 0)), Vec512<T>.Length);        

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this Vec512<T> src)
            where T : unmanaged            
                => src.ToSpan();
         
        /// <summary>
        /// Allocates a blocked span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(NotInline)]
        public static Span256<T> ToSpan256<T>(this Vec1024<T> src)
            where T : unmanaged            
         {
            var dst = BlockedSpan.AllocBlocks<T>(n256,4);
            vstore(src.v00, ref head(dst));
            vstore(src.v01, ref tail(dst,32));
            vstore(src.v10, ref tail(dst,64));
            vstore(src.v10, ref tail(dst,96));
            return dst;
        }                       

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this Vec1024<T> src)
            where T : unmanaged           
                => src.ToSpan256(); 

        /// <summary>
        /// Allocates a span into which vector content is stored
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this Vec1024<T> src)
            where T : unmanaged            
                => src.ToSpan();
    }

}
