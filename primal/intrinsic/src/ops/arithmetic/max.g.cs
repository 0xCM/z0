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
        public static Vec128<T> vmax<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.vmax(int8(x), int8(y)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.vmax(uint8(x), uint8(y)));
            else if(typematch<T,short>())
                return generic<T>(dinx.vmax(int16(x), int16(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vmax(uint16(x), uint16(y)));
            else if(typematch<T,int>())
                return generic<T>(dinx.vmax(int32(x), int32(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vmax(uint32(x), uint32(y)));
            else 
                throw unsupported<T>();
        }
         
       [MethodImpl(Inline)]
       public static Vec256<T> vmax<T>(in Vec256<T> x, in Vec256<T> y)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.vmax(int8(x), int8(y)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.vmax(uint8(x), uint8(y)));
            else if(typematch<T,short>())
                return generic<T>(dinx.vmax(int16(x), int16(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vmax(uint16(x), uint16(y)));
            else if(typematch<T,int>())
                return generic<T>(dinx.vmax(int32(x), int32(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vmax(uint32(x), uint32(y)));
            else 
                throw unsupported<T>();
        }        
    }
}