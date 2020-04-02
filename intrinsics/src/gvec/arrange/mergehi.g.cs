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
    
    using static Core;
    using static VCore;
    using static As;

    partial class gvec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
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
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left source vector</param>
        /// <param name="y">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
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
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vmergehi_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dvec.vmergehi(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dvec.vmergehi(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dvec.vmergehi(v32i(x), v32i(y)));
            else
                 return generic<T>(dvec.vmergehi(v64i(x), v64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vmergehi_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vmergehi(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vmergehi(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vmergehi(v32u(x), v32u(y)));
            else 
                return generic<T>(dvec.vmergehi(v64u(x), v64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vmergehi_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dvec.vmergehi(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dvec.vmergehi(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dvec.vmergehi(v32i(x), v32i(y)));
            else
                 return generic<T>(dvec.vmergehi(v64i(x), v64i(y)));
        }    

        [MethodImpl(Inline)]
        static Vector256<T> vmergehi_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vmergehi(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vmergehi(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vmergehi(v32u(x), v32u(y)));
            else 
                return generic<T>(dvec.vmergehi(v64u(x), v64u(y)));
        }    
    }
}
