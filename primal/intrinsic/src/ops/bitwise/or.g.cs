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
        [MethodImpl(Inline)]
        public static Vec128<T> vor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vor128u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vor128i(lhs,rhs);
            else 
                return vor128f(lhs,rhs);
        }

        [MethodImpl(Inline)]
        public static Vec256<T> vor<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vor256u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vor256i(lhs,rhs);
            else 
                return vor256f(lhs,rhs);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vor128u<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vor(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vor(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vor(uint32(lhs), uint32(rhs)));
            else
                return generic<T>(dinx.vor(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vor128i<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vor(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vor(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vor(int32(lhs), int32(rhs)));
            else
                return generic<T>(dinx.vor(int64(lhs), int64(rhs)));
        }

        static Vec128<T> vor128f<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vor(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vor(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        static Vec256<T> vor256u<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vor(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vor(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vor(uint32(lhs), uint32(rhs)));
            else
                return generic<T>(dinx.vor(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vor256i<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vor(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vor(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vor(int32(lhs), int32(rhs)));
            else
                return generic<T>(dinx.vor(int64(lhs), int64(rhs)));
        }

        static Vec256<T> vor256f<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vor(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vor(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();                    
        }
    }
}