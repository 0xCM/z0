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

        /// <summary>
        /// Applies a cross-lane permutation over 8 32-bit segments in the source vector as indicated by the perm spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector256<T> vperm8x32<T>(Vector256<T> x, Vector256<uint> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(v8u(dinx.vperm8x32(v32u(x), spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(v16u(dinx.vperm8x32(v32u(x), spec)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vperm8x32(vcast32u(x), spec));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(v64u(dinx.vperm8x32(v32u(x), spec)));
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

        [MethodImpl(Inline)]
        static Vector256<T> vperm4x64_u<T>(Vector256<T> x, Perm4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(v8u(dinx.vperm4x64(v64u(x), spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(v16u(dinx.vperm4x64(v64u(x), spec)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(v32u(dinx.vperm4x64(v64u(x), spec)));
            else
                return vgeneric<T>(dinx.vperm4x64(vcast64u(x), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm4x64_i<T>(Vector256<T> x, Perm4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(v8i(dinx.vperm4x64(v64u(x), spec)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(v16i(dinx.vperm4x64(v64u(x), spec)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(v32i(dinx.vperm4x64(v64u(x), spec)));
            else
                return vgeneric<T>(dinx.vperm4x64(vcast64i(x), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm4x64_f<T>(Vector256<T> x, Perm4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(v32f(fpinx.vperm4x64(v64f(x), spec)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vperm4x64(vcast64f(x), spec));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_u<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vperm2x128(vcast8u(lhs), vcast8u(rhs), spec));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vperm2x128(vcast16u(lhs), vcast16u(rhs), spec));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vperm2x128(vcast32u(lhs), vcast32u(rhs), spec));
            else
                return vgeneric<T>(dinx.vperm2x128(vcast64u(lhs), vcast64u(rhs), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_i<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vperm2x128(vcast8i(lhs), vcast8i(rhs), spec));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vperm2x128(vcast16i(lhs), vcast16i(rhs), spec));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vperm2x128(vcast32i(lhs), vcast32i(rhs), spec));
            else
                return vgeneric<T>(dinx.vperm2x128(vcast64i(lhs), vcast64i(rhs), spec));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vperm2x128_f<T>(Vector256<T> lhs, Vector256<T> rhs, Perm2x4 spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vperm2x128(vcast32f(lhs), vcast32f(rhs),spec));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vperm2x128(vcast64f(lhs), vcast64f(rhs),spec));
            else
                throw unsupported<T>();
        }
    }
}