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
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// Permutes 16 8-bit source vector segments
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static Vector128<T> vperm16x8<T>(Vector128<T> src, Vector128<byte> spec)        
            where T : unmanaged
                => vperm16x8_u(src,spec);

        /// <summary>
        /// Applies independent 128-bit lane permutations over 16 8-bit source vector segments
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static Vector256<T> vperm16x8<T>(Vector256<T> src, Vector256<byte> spec)        
            where T : unmanaged
                => vperm16x8_u(src,spec);

        [MethodImpl(Inline)]
        static Vector128<T> vperm16x8_u<T>(Vector128<T> src, Vector128<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vperm16x8(v8u(src), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vperm16x8(v16u(src), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vperm16x8(v32u(src), spec));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vperm16x8(v64u(src), spec));
            else
                return vperm16x8_i(src,spec);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vperm16x8_i<T>(Vector128<T> src, Vector128<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vperm16x8(v8i(src), spec));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vperm16x8(v16i(src), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vperm16x8(v32i(src), spec));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vperm16x8(v64i(src), spec));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm16x8_u<T>(Vector256<T> src, Vector256<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vperm16x8(v8u(src), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vperm16x8(v16u(src), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vperm16x8(v32u(src), spec));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vperm16x8(v64u(src), spec));
            else
                return vperm16x8_i(src,spec);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm16x8_i<T>(Vector256<T> src, Vector256<byte> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vperm16x8(v8i(src), spec));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vperm16x8(v16i(src), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vperm16x8(v32i(src), spec));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vperm16x8(v64i(src), spec));
            else
                throw unsupported<T>();
        }
    }
}