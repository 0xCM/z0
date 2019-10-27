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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Returns true if at least one of the components of the source
        /// vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bool vnonz<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnonz_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnonz_i(src);
            else 
                return vnonz_f(src);
        }

        [MethodImpl(Inline)]
        static bool vnonz_i<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vnonz(int8(src));
            else if(typeof(T) == typeof(short))
                return dinx.vnonz(int16(src));
            else if(typeof(T) == typeof(int))
                return dinx.vnonz(int32(src));
            else 
                return dinx.vnonz(int64(src));
        }

        [MethodImpl(Inline)]
        static bool vnonz_u<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vnonz(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return dinx.vnonz(uint16(src));
            else if(typeof(T) == typeof(uint))
                return dinx.vnonz(uint32(src));
            else 
                return dinx.vnonz(uint64(src));
        }

        [MethodImpl(Inline)]
        static bool vnonz_f<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.nonz(float32(src));
            else if(typeof(T) == typeof(double))
                return dfp.nonz(float64(src));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Returns true if at least one of the components of the source
        /// vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bool vnonz<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnonz_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnonz_i(src);
            else 
                return vnonz_f(src);
        }

        [MethodImpl(Inline)]
        static bool vnonz_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vnonz(int8(src));
            else if(typeof(T) == typeof(short))
                return dinx.vnonz(int16(src));
            else if(typeof(T) == typeof(int))
                return dinx.vnonz(int32(src));
            else 
                return dinx.vnonz(int64(src));
        }

        [MethodImpl(Inline)]
        static bool vnonz_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vnonz(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return dinx.vnonz(uint16(src));
            else if(typeof(T) == typeof(uint))
                return dinx.vnonz(uint32(src));
            else 
                return dinx.vnonz(uint64(src));
        }

        [MethodImpl(Inline)]
        static bool vnonz_f<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.nonz(float32(src));
            else if(typeof(T) == typeof(double))
                return dfp.nonz(float64(src));
            else 
                throw unsupported<T>();
        }


    }

}