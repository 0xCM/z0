//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Seed; 
    using static Memories;

    partial class gvec
    {
        /// <summary>
        /// Permutes 16 8-bit source vector segments
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vperm16x8<T>(Vector128<T> src, Vector128<byte> spec)        
            where T : unmanaged
                => vperm16x8_u(src,spec);

        /// <summary>
        /// Applies independent 128-bit lane permutations over 16 8-bit source vector segments
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vperm16x8<T>(Vector256<T> src, Vector256<byte> spec)        
            where T : unmanaged
                => vperm16x8_u(src,spec);

        [MethodImpl(Inline)]
        static Vector128<T> vperm16x8_u<T>(Vector128<T> src, Vector128<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vperm16x8(v8u(src), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vperm16x8(v16u(src), spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vperm16x8(v32u(src), spec));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vperm16x8(v64u(src), spec));
            else
                return vperm16x8_i(src,spec);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vperm16x8_i<T>(Vector128<T> src, Vector128<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dvec.vperm16x8(v8i(src), spec));
            else if(typeof(T) == typeof(short))
                return generic<T>(dvec.vperm16x8(v16i(src), spec));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vperm16x8(v32i(src), spec));
            else if(typeof(T) == typeof(long))
                return generic<T>(dvec.vperm16x8(v64i(src), spec));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm16x8_u<T>(Vector256<T> src, Vector256<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vperm16x8(v8u(src), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vperm16x8(v16u(src), spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vperm16x8(v32u(src), spec));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vperm16x8(v64u(src), spec));
            else
                return vperm16x8_i(src,spec);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm16x8_i<T>(Vector256<T> src, Vector256<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dvec.vperm16x8(v8i(src), spec));
            else if(typeof(T) == typeof(short))
                return generic<T>(dvec.vperm16x8(v16i(src), spec));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vperm16x8(v32i(src), spec));
            else if(typeof(T) == typeof(long))
                return generic<T>(dvec.vperm16x8(v64i(src), spec));
            else
                throw Unsupported.define<T>();
        }
    }
}