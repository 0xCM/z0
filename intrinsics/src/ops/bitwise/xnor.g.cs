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
        /// Computes ~ (x ^ y) for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vxnor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vxnor_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vxnor_i(x,y);
            else 
                return vxnor_f(x,y);
        }

        /// <summary>
        /// Computes ~ (x ^ y) for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vxnor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vxnor_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vxnor_i(x,y);
            else 
                return vxnor_f(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vxnor_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vxnor(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxnor(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vxnor(vcast32u(x), vcast32u(y)));
            else
                return generic<T>(dinx.vxnor(vcast64u(x), vcast64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vxnor_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vxnor(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vxnor(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vxnor(vcast32i(x), vcast32i(y)));
            else
                return generic<T>(dinx.vxnor(vcast64i(x), vcast64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vxnor_f<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxnor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxnor(vcast64f(x), vcast64f(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxnor_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vxnor(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxnor(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vxnor(vcast32u(x), vcast32u(y)));
            else
                return generic<T>(dinx.vxnor(vcast64u(x), vcast64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxnor_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vxnor(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vxnor(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vxnor(vcast32i(x), vcast32i(y)));
            else
                return generic<T>(dinx.vxnor(vcast64i(x), vcast64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxnor_f<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxnor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxnor(vcast64f(x), vcast64f(y)));
            else
                throw unsupported<T>();
        } 
    }
}