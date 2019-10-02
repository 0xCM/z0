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
        /// Determines whether all mask-specified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz<T>(in Vec128<T> src, in Vec128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return testz128u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return testz128i(src,mask);
            else 
                return testz128f<T>(src,mask);
         }

        [MethodImpl(Inline)]
        static bool testz128u<T>(in Vec128<T> src, in Vec128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.testz(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.testz(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.testz(uint32(src), uint32(mask));
            else
                return dinx.testz(uint64(src), uint64(mask));
        }

        [MethodImpl(Inline)]
        static bool testz128i<T>(in Vec128<T> src, in Vec128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testz(int8(src), int8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.testz(int16(src), int16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.testz(int32(src), int32(mask));
            else
                return dinx.testz(int64(src), int64(mask));
        }

        [MethodImpl(Inline)]
        static bool testz128f<T>(in Vec128<T> src, in Vec128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.testz(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dfp.testz(float64(src), float64(mask));
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bool testz256u<T>(in Vec256<T> src, in Vec256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.testz(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.testz(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.testz(uint32(src), uint32(mask));
            else
                return dinx.testz(uint64(src), uint64(mask));
        }

        [MethodImpl(Inline)]
        static bool testz256i<T>(in Vec256<T> src, in Vec256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testz(int8(src), int8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.testz(int16(src), int16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.testz(int32(src), int32(mask));
            else
                return dinx.testz(int64(src), int64(mask));
        }

        [MethodImpl(Inline)]
        static bool testz256f<T>(in Vec256<T> src, in Vec256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.testz(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dfp.testz(float64(src), float64(mask));
            else throw unsupported<T>();
        }

        /// <summary>
        /// Determines whether all mask-specified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz<T>(in Vec256<T> src, in Vec256<T> mask)
            where T : unmanaged
        {
             if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return testz256u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return testz256i(src,mask);
            else 
                return testz256f<T>(src,mask);
       }
    }
}