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
        public static Vector128<T> cmpgt<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.cmpgt(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.cmpgt(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.cmpgt(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.cmpgt(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.cmpgt(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vector256<T> cmpgt<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.cmpgt(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.cmpgt(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.cmpgt(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.cmpgt(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.cmpgt(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.cmpgt(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }

    }
}