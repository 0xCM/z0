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
        public static Vec128<T> vdec<T>(in Vec128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vdecu(in src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vdeci(src);
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> vdec<T>(in Vec256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vdecu(in src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vdeci(src);
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vec128<T> vdeci<T>(in Vec128<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vdec(in int8(in lhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vdec(in int16(in lhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vdec(in int32(in lhs)));
            else
                 return generic<T>(dinx.vdec(in int64(in lhs)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vdecu<T>(in Vec128<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vdec(in uint8(in lhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vdec(in uint16(in lhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vdec(in uint32(lhs)));
            else 
                return generic<T>(dinx.vdec(in uint64(in lhs)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vdeci<T>(in Vec256<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vdec(in int8(in lhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vdec(in int16(in lhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vdec(in int32(in lhs)));
            else
                 return generic<T>(dinx.vdec(in int64(in lhs)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vdecu<T>(in Vec256<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vdec(in uint8(in lhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vdec(in uint16(in lhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vdec(in uint32(lhs)));
            else 
                return generic<T>(dinx.vdec(in uint64(in lhs)));
        }

    }
}