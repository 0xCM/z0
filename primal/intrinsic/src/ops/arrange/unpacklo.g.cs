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
        [MethodImpl(Inline)]
        public static Vector128<T> vunpacklo<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vunpacklo_u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vunpacklo_i(lhs,rhs);
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vunpacklo<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vunpacklo_u(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vunpacklo_i(lhs,rhs);
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vunpacklo_i<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vunpacklo(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vunpacklo(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vunpacklo(int32(lhs), int32(rhs)));
            else
                 return generic<T>(dinx.vunpacklo(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vunpacklo_u<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vunpacklo(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vunpacklo(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vunpacklo(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(dinx.vunpacklo(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vunpacklo_i<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vunpacklo(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vunpacklo(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vunpacklo(int32(lhs), int32(rhs)));
            else
                 return generic<T>(dinx.vunpacklo(int64(lhs), int64(rhs)));
        }    


        [MethodImpl(Inline)]
        static Vector256<T> vunpacklo_u<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vunpacklo(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vunpacklo(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vunpacklo(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(dinx.vunpacklo(uint64(lhs), uint64(rhs)));
        }    
    }
}
