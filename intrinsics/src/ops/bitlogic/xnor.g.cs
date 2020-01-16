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
        /// Computes ~ (x ^ y) for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Vector128<T> vxnor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vxnor_u(x,y);

        /// <summary>
        /// Computes ~ (x ^ y) for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Vector256<T> vxnor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vxnor_u(x,y);

        [MethodImpl(Inline)]
        static Vector128<T> vxnor_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vxnor(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxnor(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vxnor(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vxnor(v64u(x), v64u(y)));
            else
                return vxnor_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vxnor_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vxnor(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vxnor(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vxnor(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vxnor(v64i(x), v64i(y)));
            else
                return vxnor_f(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vxnor_f<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxnor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxnor(v64f(x), v64f(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxnor_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vxnor(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxnor(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vxnor(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vxnor(v64u(x), v64u(y)));
            else
                return vxnor_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxnor_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vxnor(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vxnor(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vxnor(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vxnor(v64i(x), v64i(y)));
            else
                return vxnor_f(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxnor_f<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxnor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxnor(v64f(x), v64f(y)));
            else
                throw unsupported<T>();
        } 
    }
}