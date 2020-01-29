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
        /// Computes the converse nonimplication z := x & (~y) for operands x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vcnonimpl<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vcnonimpl_u(x,y);

        /// <summary>
        /// Computes the converse nonimplication z := x & (~y) for operands x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vcnonimpl<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vcnonimpl_u(x,y);

        [MethodImpl(Inline)]
        static Vector128<T> vcnonimpl_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vcnonimpl(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vcnonimpl(v16u(x),v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vcnonimpl(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vcnonimpl(v64u(x), v64u(y)));
            else 
                return vcnonimpl_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vcnonimpl_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vcnonimpl(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vcnonimpl(v16i(x),v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vcnonimpl(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vcnonimpl(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vcnonimpl_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vcnonimpl(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vcnonimpl(v16u(x),v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vcnonimpl(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vcnonimpl(v64u(x), v64u(y)));
            else 
                return vcnonimpl_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vcnonimpl_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vcnonimpl(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vcnonimpl(v16i(x),v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vcnonimpl(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vcnonimpl(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
        }
    }
}