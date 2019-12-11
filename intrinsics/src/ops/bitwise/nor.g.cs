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
        /// Computes ~(x | y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vnor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnor_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnor_i(x,y);
            else 
                return vnor_f(x,y);
        }

        /// <summary>
        /// Computes ~(x | y) for vectors x and y
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vnor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnor_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnor_i(x,y);
            else 
                return vnor_f(x,y);
        }


        [MethodImpl(Inline)]
        static Vector128<T> vnor_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vnor(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnor(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnor(vcast32u(x), vcast32u(y)));
            else
                return vgeneric<T>(dinx.vnor(vcast64u(x), vcast64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnor_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vnor(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vnor(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnor(vcast32i(x), vcast32i(y)));
            else
                return vgeneric<T>(dinx.vnor(vcast64i(x), vcast64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnor_f<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vnor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vnor(vcast64f(x), vcast64f(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnor_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vnor(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnor(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnor(vcast32u(x), vcast32u(y)));
            else
                return vgeneric<T>(dinx.vnor(vcast64u(x), vcast64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnor_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vnor(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vnor(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnor(vcast32i(x), vcast32i(y)));
            else
                return vgeneric<T>(dinx.vnor(vcast64i(x), vcast64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnor_f<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vnor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vnor(vcast64f(x), vcast64f(y)));
            else
                throw unsupported<T>();
        }
    }
}