//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    using static Seed; 
    using static Memories;

    partial class gmath
    {        
        /// <summary>
        /// Computes dst = (div(a,b), mod(a,b))
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), DivMod, Closures(AllNumeric)]
        public static ConstPair<T> divmod<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return divmod_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return divmod_i(a,b);
            else 
                return gfp.divmod(a,b);
        }

        [MethodImpl(Inline)]
        static ConstPair<T> divmod_i<T>(T a, T m)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return ConstPair.generic<T>(math.divmod(int8(a), int8(m)));
            else if(typeof(T) == typeof(short))
                return ConstPair.generic<T>(math.divmod(int16(a), int16(m)));
            else if(typeof(T) == typeof(int))
                 return ConstPair.generic<T>(math.divmod(int32(a), int32(m)));
            else
                 return ConstPair.generic<T>(math.divmod(int64(a), int64(m)));
        }

        [MethodImpl(Inline)]
        static ConstPair<T> divmod_u<T>(T a, T m)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return ConstPair.generic<T>(math.divmod(uint8(a), uint8(m)));
            else if(typeof(T) == typeof(ushort))
                return ConstPair.generic<T>(math.divmod(uint16(a), uint16(m)));
            else if(typeof(T) == typeof(uint))
                return ConstPair.generic<T>(math.divmod(uint32(a), uint32(m)));
            else 
                return ConstPair.generic<T>(math.divmod(uint64(a), uint64(m)));
        }
    }
}
