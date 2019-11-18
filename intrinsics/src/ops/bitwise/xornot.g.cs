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
        /// Computes x ^ ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vxornot<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vxornot_128u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vxornot_128i(x,y);
            else 
                return vxornot_128f(x,y);
        }

        /// <summary>
        /// Computes x ^ ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vxornot<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vxornot_256u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vxornot_256i(x,y);
            else 
                return vxornot_256f(x,y);
        }


        [MethodImpl(Inline)]
        static Vector128<T> vxornot_128u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vxornot(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxornot(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vxornot(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vxornot(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vxornot_128i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vxornot(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vxornot(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vxornot(int32(x), int32(y)));
            else
                return generic<T>(dinx.vxornot(int64(x), int64(y)));
        }

 
        [MethodImpl(Inline)]
        static Vector128<T> vxornot_128f<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxornot(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxornot(float64(x), float64(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxornot_256u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vxornot(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxornot(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vxornot(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vxornot(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxornot_256i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vxornot(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vxornot(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vxornot(int32(x), int32(y)));
            else
                return generic<T>(dinx.vxornot(int64(x), int64(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxornot_256f<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxornot(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxornot(float64(x), float64(y)));
            else
                throw unsupported<T>();
        }

    }
}