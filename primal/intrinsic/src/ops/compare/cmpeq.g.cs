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
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<T> vcmpeq<T>(in Vec128<T> lhs, in Vec128<T> rhs)
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
        /// Compares corresponding components in each vector for equality. For equal
        /// components, the corresponding component in the result vector has all bits 
        /// enabled; otherwise, all bits in the component are disabled
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<T> vcmpeq<T>(in Vec256<T> lhs, in Vec256<T> rhs)
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
        static Vec128<T> vcmpeq_i<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vcmpeq(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vcmpeq(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vcmpeq(in int32(in lhs), in int32(in rhs)));
            else 
                return generic<T>(dinx.vcmpeq(in int64(in lhs), in int64(in rhs)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vcmpeq_u<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vcmpeq(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcmpeq(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcmpeq(in uint32(in lhs), in uint32(in rhs)));
            else 
                return generic<T>(dinx.vcmpeq(in uint64(in lhs), in uint64(in rhs)));
        }


        [MethodImpl(Inline)]
        static Vec128<T> vcmpeq_f<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.cmpeq(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.cmpeq(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vec256<T> vcmpeq_i<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vcmpeq(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vcmpeq(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vcmpeq(in int32(in lhs), in int32(in rhs)));
            else 
                return generic<T>(dinx.vcmpeq(in int64(in lhs), in int64(in rhs)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vcmpeq_u<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vcmpeq(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vcmpeq(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vcmpeq(in uint32(in lhs), in uint32(in rhs)));
            else 
                return generic<T>(dinx.vcmpeq(in uint64(in lhs), in uint64(in rhs)));
        }


        [MethodImpl(Inline)]
        static Vec256<T> vcmpeq_f<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.cmpeq(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.cmpeq(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }


    }
}