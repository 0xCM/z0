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
    
    using static Root;
    using static gvec;
    
    partial class ginx
    {
        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vcimpl<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vcimpl_u(x,y);

        /// <summary>
        /// Computes the converse implication, ~x | y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vcimpl<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vcimpl_u(x,y);

        [MethodImpl(Inline)]
        static Vector128<T> vcimpl_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vcimpl(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcimpl(v16u(x),v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcimpl(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vcimpl(v64u(x), v64u(y)));
            else 
                return vcimpl_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vcimpl_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vcimpl(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vcimpl(v16i(x),v16i(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vcimpl(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.vcimpl(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vcimpl_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vcimpl(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcimpl(v16u(x),v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcimpl(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vcimpl(v64u(x), v64u(y)));
            else 
                return vcimpl_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vcimpl_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
             if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vcimpl(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vcimpl(v16i(x),v16i(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vcimpl(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.vcimpl(v64i(x), v64i(y)));
            else 
                throw unsupported<T>();
       }
    }
}