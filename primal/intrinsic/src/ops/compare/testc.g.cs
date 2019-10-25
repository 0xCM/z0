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
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bool vtestc<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return testc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return testc_i(src,mask);
            else 
                return testc_f(src,mask);
        }

        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bool vtestc<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return testc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return testc_i(src,mask);
            else 
                return testc_f(src,mask);
        }

        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        static bool testc_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestc(int8(src), int8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestc(int16(src), int16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestc(int32(src), int32(mask));
            else 
                return dinx.vtestc(int64(src), int64(mask));
        }

        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        static bool testc_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestc(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestc(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestc(uint32(src), uint32(mask));
            else 
                return dinx.vtestc(uint64(src), uint64(mask));
        }

        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        static bool testc_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.vtestc(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dfp.vtestc(float64(src), float64(mask));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bool testc_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestc(int8(src), int8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestc(int16(src), int16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestc(int32(src), int32(mask));
            else 
                return dinx.vtestc(int64(src), int64(mask));
        }

        [MethodImpl(Inline)]
        static bool testc_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestc(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestc(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestc(uint32(src), uint32(mask));
            else 
                return dinx.vtestc(uint64(src), uint64(mask));
        }

        [MethodImpl(Inline)]
        static bool testc_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.vtestc(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dfp.vtestc(float64(src), float64(mask));
            else 
                throw unsupported<T>();
        }

    }

}