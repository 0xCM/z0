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
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {

        /// <summary>
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vcmpeq<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vcmpeq_u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vcmpeq_i(lhs,rhs);
            else 
                return vcmpeq_f<T>(lhs,rhs);
        }

        /// <summary>
        /// Compares corresponding components each vector for equality. For equal
        /// components, the corresponding component the result vector has all bits 
        /// enabled; otherwise, all bits the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vcmpeq<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vcmpeq_u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vcmpeq_i(lhs,rhs);
            else 
                return vcmpeq_f<T>(lhs,rhs);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vcmpeq_i<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vcmpeq(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vcmpeq(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vcmpeq(int32(lhs), int32(rhs)));
            else 
                return generic<T>(dinx.vcmpeq(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vcmpeq_u<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vcmpeq(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcmpeq(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcmpeq(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(dinx.vcmpeq(uint64(lhs), uint64(rhs)));
        }


        [MethodImpl(Inline)]
        static Vector128<T> vcmpeq_f<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.cmpeq(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.cmpeq(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vector256<T> vcmpeq_i<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vcmpeq(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vcmpeq(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vcmpeq(int32(lhs), int32(rhs)));
            else 
                return generic<T>(dinx.vcmpeq(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vcmpeq_u<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vcmpeq(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcmpeq(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcmpeq(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(dinx.vcmpeq(uint64(lhs), uint64(rhs)));
        }


        [MethodImpl(Inline)]
        static Vector256<T> vcmpeq_f<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.cmpeq(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.cmpeq(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }


    }
}