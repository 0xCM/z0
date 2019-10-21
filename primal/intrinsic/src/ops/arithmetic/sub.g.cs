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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    
    using static zfunc;
    using static As;
    

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vsub<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsubu(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsubi(x,y);
            else return gfpv.vadd(x,y);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsub<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsubu(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsubi(x,y);
            else return gfpv.vadd(x,y);
       }
            
        [MethodImpl(Inline)]
        static Vector128<T> vsubi<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vsub(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vsub(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vsub(int32(x), int32(y)));
            else
                 return generic<T>(dinx.vsub(int64(x), int64(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsubu<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsub(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsub(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vsub(uint32(x), uint32(y)));
            else 
                return generic<T>(dinx.vsub(uint64(x), uint64(y)));
        }


        [MethodImpl(Inline)]
        static Vector256<T> vsubi<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vsub(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vsub(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vsub(int32(x), int32(y)));
            else
                 return generic<T>(dinx.vsub(int64(x), int64(y)));
        }    


        [MethodImpl(Inline)]
        static Vector256<T> vsubu<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsub(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsub(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vsub(uint32(x), uint32(y)));
            else 
                return generic<T>(dinx.vsub(uint64(x), uint64(y)));
        }    


    }
}