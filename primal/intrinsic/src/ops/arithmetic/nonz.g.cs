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
        public static bool vnonz<T>(in Vec128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vnonz(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return dinx.vnonz(in uint8(in src));
            else if(typeof(T) == typeof(short))
                return dinx.vnonz(in int16(in src));
            else if(typeof(T) == typeof(ushort))
                return dinx.vnonz(in uint16(in src));
            else if(typeof(T) == typeof(int))
                return dinx.vnonz(in int32(in src));
            else if(typeof(T) == typeof(uint))
                return dinx.vnonz(in uint32(in src));
            else if(typeof(T) == typeof(long))
                return dinx.vnonz(in int64(in src));
            else if(typeof(T) == typeof(ulong))
                return dinx.vnonz(in uint64(in src));
            else if(typeof(T) == typeof(float))
                return dfp.nonz(in float32(in src));
            else if(typeof(T) == typeof(double))
                return dfp.nonz(in float64(in src));
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
        public static bool nonz<T>(in Vec256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vnonz(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return dinx.vnonz(in uint8(in src));
            else if(typeof(T) == typeof(short))
                return dinx.vnonz(in int16(in src));
            else if(typeof(T) == typeof(ushort))
                return dinx.vnonz(in uint16(in src));
            else if(typeof(T) == typeof(int))
                return dinx.vnonz(in int32(in src));
            else if(typeof(T) == typeof(uint))
                return dinx.vnonz(in uint32(in src));
            else if(typeof(T) == typeof(long))
                return dinx.vnonz(in int64(in src));
            else if(typeof(T) == typeof(ulong))
                return dinx.vnonz(in uint64(in src));
            else if(typeof(T) == typeof(float))
                return dfp.nonz(in float32(in src));
            else if(typeof(T) == typeof(double))
                return dfp.nonz(in float64(in src));
            else 
                throw unsupported<T>();
        }         

    }

}