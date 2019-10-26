//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    
    using static AsIn;    
    using static As;

    partial class ginx
    {        

        /// <summary>
        /// Extracts lo 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vlo<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vlo_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vlo_i(src);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vlo_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vlo(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vlo(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vlo(int32(src)));
            else
                return generic<T>(dinx.vlo(int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vlo_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vlo(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vlo(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vlo(uint32(src)));
            else 
                return generic<T>(dinx.vlo(uint64(src)));
        }
         
    }
}