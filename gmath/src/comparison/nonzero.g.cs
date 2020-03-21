//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;

    partial class gmath
    {
        /// <summary>
        /// Returns 1 if the source operand is non-zero and 0 otherwise
        /// </summary>
        /// <param name="a">The source operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit nonz<T>(T a)
            where T : unmanaged
                => Numeric.nonz(a);

        [MethodImpl(Inline)]
        static bit nonz_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return math.nonz(uint8(a));
            else if(typeof(T) == typeof(ushort))
                 return math.nonz(uint16(a));
            else if(typeof(T) == typeof(uint))
                 return math.nonz(uint32(a));
            else if(typeof(T) == typeof(ulong))
                 return math.nonz(uint64(a));
            else 
                return nonz_i(a);
        }

        [MethodImpl(Inline)]
        static bit nonz_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.nonz(int8(a));
            else if(typeof(T) == typeof(short))
                 return math.nonz(int16(a));
            else if(typeof(T) == typeof(int))
                 return math.nonz(int32(a));
            else if(typeof(T) == typeof(long))
                 return math.nonz(int64(a));
            else 
                return gfp.nonz(a);
        }
    }
}