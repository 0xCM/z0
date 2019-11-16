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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static As;
    using static AsIn;

    using static zfunc;
    using static aux;
    
    partial class ginx
    {        
        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit segment of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask<T>(Vector128<T> src)
            where T : unmanaged
                => (uint)MoveMask(v8u(src));

        /// <summary>
        /// _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit segment of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static uint vmovemask<T>(Vector256<T> src)
            where T : unmanaged
                => (uint)MoveMask(v8u(src));

        [MethodImpl(Inline)]
        public static unsafe void vmaskstore<T>(Vector128<T> src, Vector128<byte> mask, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vmaskstore_i(src,mask,ref dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vmaskstore_u(src,mask,ref dst);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe void vmaskstore<T>(Vector256<T> src, Vector256<byte> mask, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vmaskstore_i(src,mask,ref dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vmaskstore_u(src,mask,ref dst);
            else 
                throw unsupported<T>();
        }

    }
}