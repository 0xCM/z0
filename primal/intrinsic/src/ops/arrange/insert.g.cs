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
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vec256<T> insert<T>(in Vec128<T> src, in Vec256<T> dst, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return insert_u(src,dst,index);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return insert_i(src,dst,index);
            else 
                return insert_f(src,dst,index);
        }

        [MethodImpl(Inline)]
        static Vec256<T> insert_i<T>(in Vec128<T> src, in Vec256<T> dst, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.insert(int8(src), int8(dst), index));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.insert(int16(src), int16(dst), index));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.insert(int32(src), int32(dst), index));
            else 
                return generic<T>(dinx.insert(int64(src), int64(dst), index));
        }

        [MethodImpl(Inline)]
        static Vec256<T> insert_u<T>(in Vec128<T> src, in Vec256<T> dst, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.insert(uint8(src), uint8(dst), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.insert(uint16(src), uint16(dst), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.insert(int64(src), int64(dst), index));
            else 
                return generic<T>(dinx.insert(uint64(src), uint64(dst), index));
        }

        [MethodImpl(Inline)]
        static Vec256<T> insert_f<T>(in Vec128<T> src, in Vec256<T> dst, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.insert(float32(src), float32(dst), index));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.insert(float64(src), float64(dst), index));
            else
                throw unsupported<T>();
        }
    }
}