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
        public static Vec128<T> unpackhi<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return unpackhiu(in lhs,in rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return unpackhii(lhs,rhs);
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> unpackhi<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return unpackhiu(in lhs,in rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return unpackhii(lhs,rhs);
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vec128<T> unpackhii<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.unpackhi(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.unpackhi(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.unpackhi(in int32(in lhs), in int32(in rhs)));
            else
                 return generic<T>(dinx.unpackhi(in int64(in lhs), in int64(in rhs)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> unpackhiu<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.unpackhi(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.unpackhi(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.unpackhi(in uint32(lhs), in uint32(in rhs)));
            else 
                return generic<T>(dinx.unpackhi(in uint64(in lhs), in uint64(in rhs)));
        }


        [MethodImpl(Inline)]
        static Vec256<T> unpackhii<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.unpackhi(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.unpackhi(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.unpackhi(in int32(in lhs), in int32(in rhs)));
            else
                 return generic<T>(dinx.unpackhi(in int64(in lhs), in int64(in rhs)));
        }    


        [MethodImpl(Inline)]
        static Vec256<T> unpackhiu<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.unpackhi(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.unpackhi(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.unpackhi(in uint32(lhs), in uint32(in rhs)));
            else 
                return generic<T>(dinx.unpackhi(in uint64(in lhs), in uint64(in rhs)));
        }    
    }
}
