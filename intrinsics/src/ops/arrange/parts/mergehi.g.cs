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
    
    using static zfunc;
    using static As;

    partial class ginx
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector128<T> vmergehi<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vmergehi_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vmergehi_i(x,y);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector256<T> vmergehi<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vmergehi_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vmergehi_i(x,y);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vmergehi_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return vgeneric<T>(dinx.vmergehi(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return vgeneric<T>(dinx.vmergehi(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return vgeneric<T>(dinx.vmergehi(v32i(x), v32i(y)));
            else
                 return vgeneric<T>(dinx.vmergehi(v64i(x), v64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vmergehi_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vmergehi(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vmergehi(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vmergehi(v32u(x), v32u(y)));
            else 
                return vgeneric<T>(dinx.vmergehi(v64u(x), v64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vmergehi_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return vgeneric<T>(dinx.vmergehi(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return vgeneric<T>(dinx.vmergehi(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return vgeneric<T>(dinx.vmergehi(v32i(x), v32i(y)));
            else
                 return vgeneric<T>(dinx.vmergehi(v64i(x), v64i(y)));
        }    

        [MethodImpl(Inline)]
        static Vector256<T> vmergehi_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vmergehi(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vmergehi(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vmergehi(v32u(x), v32u(y)));
            else 
                return vgeneric<T>(dinx.vmergehi(v64u(x), v64u(y)));
        }    
    }
}
