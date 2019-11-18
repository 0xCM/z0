//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class ginx
    {    
        
        [MethodImpl(Inline)]
        public static Vector128<T> vsrl<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsrl(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsrl(uint16(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsrl(uint32(x), offset));
            else 
                return generic<T>(dinx.vsrl(uint64(x), offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsrl<T>(Vector256<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsrl(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsrl(uint16(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsrl(uint32(x), offset));
            else 
                return generic<T>(dinx.vsrl(uint64(x), offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsrl<T>(Vector256<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsrl_u(x,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsrl_i(x,offset);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrl_i<T>(Vector256<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vsrl(int8(x), int8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vsrl(int16(x), int16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vsrl(int32(x), int32(offset)));
            else 
                return generic<T>(dinx.vsrl(int64(x), int64(offset)));            
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrl_u<T>(Vector256<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsrl(uint8(x), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsrl(uint16(x), uint16(offset)));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsrl(uint32(x), uint32(offset)));
            else 
                return generic<T>(dinx.vsrl(uint64(x), uint64(offset)));
        }

    }
}