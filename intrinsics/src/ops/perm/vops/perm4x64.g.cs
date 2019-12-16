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
        /// Permutes 4 64-bit source vector segments as described by the perm spec
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vperm4x64<T>(Vector256<T> x, Perm4L spec)
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
        static Vector256<T> vperm4x64_u<T>(Vector256<T> x, Perm4L spec)
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
        static Vector256<T> vperm4x64_i<T>(Vector256<T> x, Perm4L spec)
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
        static Vector256<T> vperm4x64_f<T>(Vector256<T> x, Perm4L spec)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(v32f(fpinx.vperm4x64(v64f(x), spec)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vperm4x64(vcast64f(x), spec));
            else
                throw unsupported<T>();
        }

    }
}