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

    using static As;
    using static AsIn;

    using static zfunc;
    using static aux;
    
    partial class ginx
    {        
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vload<T>(N128 n, in T src)
            where T : unmanaged                    
                => vload(constptr(in src), out Vector128<T> _);
        
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vload<T>(N256 n, in T src)
            where T : unmanaged
                => vload(constptr(in src), out Vector256<T> _);

        [MethodImpl(Inline)]
        public static unsafe ref Vector128<T> vload<T>(in T src, out Vector128<T> dst)
            where T : unmanaged
                => ref vload(constptr(in src), out dst);

        [MethodImpl(Inline)]
        public static unsafe ref Vector256<T> vload<T>(in T src, out Vector256<T> dst)
            where T : unmanaged
                => ref vload(constptr(in src), out dst);

        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(N128 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vload_u(n, in src, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vload_i(n,in src, offset);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(N256 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vload_u(n, in src, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vload_i(n, in src, offset);
            else 
                throw unsupported<T>();
        }

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

        /// <summary>
        /// Loads a 128-bit vector from the first 128-bit source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(in Block128<T> src)
            where T : unmanaged
                =>  vload(n128,src.Data);

        /// <summary>
        /// Loads a block-identified 128-bit vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(in Block128<T> src, int block)            
            where T : unmanaged      
                => vload(in src.BlockRef(block), out Vector128<T> x);

        /// <summary>
        /// Loads a 128-bit vector from the first 128-bit source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(in ConstBlock128<T> src)
            where T : unmanaged
                =>  vload(n128,src.Data);

        /// <summary>
        /// Loads a block-identified 128-bit vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vload<T>(in ConstBlock128<T> src, int block)            
            where T : unmanaged      
                => vload(in src.BlockRef(block), out Vector128<T> x);

        /// <summary>
        /// Loads a 256-bit vector from the first 256-bit source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(in Block256<T> src)
            where T : unmanaged
                =>  vload(n256,src.Data);

        /// <summary>
        /// Loads a block-identified 256-bit vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(in Block256<T> src, int block)            
            where T : unmanaged      
                => vload(in src.BlockRef(block), out Vector256<T> x);

        /// <summary>
        /// Loads a 256-bit vector from the first 256-bit source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(in ConstBlock256<T> src)
            where T : unmanaged
                => vload(n256,src.Data);

        /// <summary>
        /// Loads a block-identified 256-bit vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vload<T>(in ConstBlock256<T> src, int block)            
            where T : unmanaged      
                => vload(in src.BlockRef(block), out Vector256<T> x);

        [MethodImpl(Inline)]
        public static unsafe ref Vector128<T> vload<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vloadu_u(pSrc, out dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vloadu_i(pSrc, out dst);
            else
                vloadu_f(pSrc, out dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Vector256<T> vload<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vloadu_u(pSrc, out dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vloadu_i(pSrc, out dst);
            else
                vloadu_f(pSrc, out dst);
            
            return ref dst;
        }
    }
}
