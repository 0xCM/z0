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
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector256<T> vpermd<T>(Vector256<T> x, Perm8Spec spec)
            where T : unmanaged
                => vperm8x32(x, vload(n256, in head(spec.ToSpan<uint>())));

        /// <summary>
        /// Applies a cross-lane permutation over 8 32-bit segments in the source vector as indicated by the perm spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector256<T> vperm8x32<T>(Vector256<T> x, Vector256<uint> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vperm8x32(uint8(x), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vperm8x32(uint16(x),spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vperm8x32(uint32(x), spec));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vperm8x32(uint64(x), spec));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Permutes 4 64-bit source vector segments as described by the perm spec
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vperm4x64<T>(Vector256<T> x, Perm4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vperm4x64_u(x,spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vperm4x64_i(x,spec);
            else 
                return vperm4x64_f(x,spec);
        }

        /// <summary>
        /// Permutes 4 128-bit source lanes from 2 256-bit vectors as described by the perm spec
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vperm2x128<T>(Vector256<T> x, Vector256<T> y, Perm2x4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vperm2x128_u(x,y,spec);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vperm2x128_i(x,y,spec);
            else 
                return vperm2x128_f(x,y,spec);
        }

 
        [MethodImpl(Inline)]
        static Vector256<T> vperm4x64_u<T>(Vector256<T> x, Perm4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vperm4x64(uint8(x), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vperm4x64(uint16(x), spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vperm4x64(uint32(x), spec));
            else
                return generic<T>(dinx.vperm4x64(uint64(x), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm4x64_i<T>(Vector256<T> x, Perm4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vperm4x64(int8(x), spec));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vperm4x64(int16(x), spec));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vperm4x64(int32(x), spec));
            else
                return generic<T>(dinx.vperm4x64(int64(x), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm4x64_f<T>(Vector256<T> x, Perm4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vperm4x64(float32(x), spec));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vperm4x64(float64(x), spec));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_u<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vperm2x128(uint8(lhs), uint8(rhs), spec));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vperm2x128(uint16(lhs), uint16(rhs), spec));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vperm2x128(uint32(lhs), uint32(rhs), spec));
            else
                return generic<T>(dinx.vperm2x128(uint64(lhs), uint64(rhs), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_i<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vperm2x128(int8(lhs), int8(rhs), spec));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vperm2x128(int16(lhs), int16(rhs), spec));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vperm2x128(int32(lhs), int32(rhs), spec));
            else
                return generic<T>(dinx.vperm2x128(int64(lhs), int64(rhs), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_f<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vperm2x128(float32(lhs), float32(rhs),spec));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vperm2x128(float64(lhs), float64(rhs),spec));
            else
                throw unsupported<T>();
        }
    }
}