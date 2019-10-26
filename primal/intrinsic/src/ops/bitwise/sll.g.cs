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
        /// <summary>
        /// Shifts the entire 128-bit vector leftwards at bit-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The number of bits the shift rightward</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vsllx<T>(Vector128<T> src, byte offset)        
            where T : unmanaged
                => generic<T>(dinxc.vsllx(src.AsUInt64(), offset));


        [MethodImpl(Inline)]
        public static Vector128<T> vsll<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsll_u(x,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsll_i(x,offset);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsll_i<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vsll(int8(x), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vsll(int16(x), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vsll(int32(x), offset));
            else 
                return generic<T>(dinx.vsll(int64(x), offset));            
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsll_u<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsll(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsll(uint16(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsll(uint32(x), offset));
            else 
                return generic<T>(dinx.vsll(uint64(x), offset));
        }


        [MethodImpl(Inline)]
        public static Vector256<T> vsll<T>(Vector256<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsll_u(x,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsll_i(x,offset);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_i<T>(Vector256<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vsll(int8(x), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vsll(int16(x), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vsll(int32(x), offset));
            else 
                return generic<T>(dinx.vsll(int64(x), offset));            
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_u<T>(Vector256<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsll(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsll(uint16(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsll(uint32(x), offset));
            else 
                return generic<T>(dinx.vsll(uint64(x), offset));
        }


    }
}