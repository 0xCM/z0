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
        /// <summary>
        /// Extract a component from a 128-bit cpu vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        [MethodImpl(Inline)]
        public static T vextract<T>(Vector128<T> src, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vextract_u(src,index);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vextract_i(src,index);
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static T vextract_i<T>(Vector128<T> src, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vextract(int8(src), index));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vextract(int16(src), index));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vextract(int32(src), index));
            else 
                return generic<T>(dinx.vextract(int64(src), index));
        }

        [MethodImpl(Inline)]
        static T vextract_u<T>(Vector128<T> src, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vextract(uint8(src), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vextract(uint16(src), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vextract(int64(src), index));
            else 
                return generic<T>(dinx.vextract(uint64(src), index));
        }

 
    }
}