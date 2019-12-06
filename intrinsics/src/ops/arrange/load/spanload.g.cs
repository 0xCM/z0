//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;

    using static zfunc;
    
    partial class ginx
    {        
        /// <summary>
        /// Loads a 128-bit vector from the first 128 bits of the source
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, Span<T> src)
            where T : unmanaged
                => vload(n, in head(src));

        /// <summary>
        /// Loads a 128-bit vector beginning at a specified source cell offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, Span<T> src, int offset)
            where T : unmanaged            
                => vload(n, in seek(src, offset));

        /// <summary>
        /// Loads a 128-bit vector from the first 128 bits of the source
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, ReadOnlySpan<T> src)
            where T : unmanaged
                => vload(n, in head(src));

        /// <summary>
        /// Loads a 128-bit vector beginning at a specified source cell offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, ReadOnlySpan<T> src, int offset)
            where T : unmanaged            
                => vload(n, in skip(src, offset));

        /// <summary>
        /// Loads a 256-bit vector from the first 256 bits of the source
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, Span<T> src)
            where T : unmanaged
                => vload(n, in head(src));

        /// <summary>
        /// Loads a 256-bit vector beginning at a specified source cell offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, Span<T> src, int offset)
            where T : unmanaged            
                => vload(n, in seek(src, offset));

        /// <summary>
        /// Loads a 256-bit vector from the first 256 bits of the source
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, ReadOnlySpan<T> src)
            where T : unmanaged
                => vload(n, in head(src));

        /// <summary>
        /// Loads a 256-bit vector beginning at a specified source cell offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, ReadOnlySpan<T> src, int offset)
            where T : unmanaged            
                => vload(n, in skip(src, offset));

        /// <summary>
        /// Loads a generic 128-bit cpu vector from a bytespan
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vload(n, MemoryMarshal.Cast<byte,T>(src));

        /// <summary>
        /// Loads a generic 256-bit cpu vector from a bytespan
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The primal vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, ReadOnlySpan<byte> src)
            where T : unmanaged
                => vload(n, MemoryMarshal.Cast<byte,T>(src));
    }

}