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
        public static Vector128<T> vmin<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vmin_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vmin_i(x,y);
            else 
                return gfpv.vmin(x,y);
        }
         
       [MethodImpl(Inline)]
       public static Vector256<T> vmin<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vmin_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vmin_i(x,y);
            else 
                return gfpv.vmin(x,y);
        }        

        [MethodImpl(Inline)]
        static Vector128<T> vmin_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vmin(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vmin(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vmin(int32(x), int32(y)));
            else
                 return generic<T>(dinx.vmin(int64(x), int64(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vmin_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vmin(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vmin(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vmin(uint32(x), uint32(y)));
            else 
                return generic<T>(dinx.vmin(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vmin_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vmin(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vmin(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vmin(int32(x), int32(y)));
            else
                 return generic<T>(dinx.vmin(int64(x), int64(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vmin_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vmin(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vmin(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vmin(uint32(x), uint32(y)));
            else 
                return generic<T>(dinx.vmin(uint64(x), uint64(y)));
        } 
    }
}