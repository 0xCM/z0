//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public static class BitStringX
    {
        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this sbyte src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this byte src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this short src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ushort src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this int src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this uint src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this long src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ulong src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this float src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts the source value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this double src, int? maxbits = null)
            => BitString.scalar(src);

        /// <summary>
        /// Converts a bitspan to a to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString(this Span<bit> src)
            => BitString.bitspan((ReadOnlySpan<bit>)src); 

        /// <summary>
        /// Converts a readonly bitspan to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString(this ReadOnlySpan<bit> src)
            => BitString.bitspan(src);

        /// <summary>
        /// Converts span content to a to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Span<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src, maxbits); 

        /// <summary>
        /// Converts blocked content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block64<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Data, maxbits ?? Block64<T>.N);

        /// <summary>
        /// Converts blocked content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block128<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Data, maxbits ?? Block128<T>.N);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Block256<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Data, maxbits ?? Block256<T>.N);

        /// <summary>
        /// Converts blocked content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this ConstBlock64<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Data, maxbits ?? ConstBlock64<T>.N);

        /// <summary>
        /// Converts blocked content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this ConstBlock128<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Data, maxbits ?? ConstBlock128<T>.N);

        /// <summary>
        /// Converts datablock content to a bitstring
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this ConstBlock256<T> src, int? maxbits = null)
            where T : unmanaged
                => BitString.scalars(src.Data, maxbits ?? ConstBlock256<T>.N);

        /// <summary>
        /// Converts a bitview to a bitstring
        /// </summary>
        /// <param name="src">The view source</param>
        /// <typeparam name="T">The data type on which the view is predicated</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this BitView<T> src)
            where T : unmanaged
                => src.Bytes.ToBitString();
    
        /// <summary>
        /// Converts a 128-bit unsigned integer to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this UInt128 src)
            => BitString.scalar(src.hi) + BitString.scalar(src.lo);
 
        /// <summary>
        /// Converts an 128-bit intrinsic vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vector128<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.scalars(src.ToSpan(), maxbits);
        
        /// <summary>
        /// Converts an 256-bit intrinsic vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vector256<T> src, int? maxbits = null)
            where T : unmanaged        
                => BitString.scalars(src.ToSpan(), maxbits);        

        /// <summary>
        /// Converts an enumeration value to a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The enumeration type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this T src)
            where T : unmanaged, Enum
                => BitString.@enum(src);

    }
}