//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;

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
                => nonz_u(a);

        [MethodImpl(Inline)]
        static bit nonz_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return math.nonzero(uint8(a));
            else if(typeof(T) == typeof(ushort))
                 return math.nonzero(uint16(a));
            else if(typeof(T) == typeof(uint))
                 return math.nonzero(uint32(a));
            else if(typeof(T) == typeof(ulong))
                 return math.nonzero(uint64(a));
            else 
                return nonz_i(a);
        }

        [MethodImpl(Inline)]
        static bit nonz_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.nonzero(int8(a));
            else if(typeof(T) == typeof(short))
                 return math.nonzero(int16(a));
            else if(typeof(T) == typeof(int))
                 return math.nonzero(int32(a));
            else if(typeof(T) == typeof(long))
                 return math.nonzero(int64(a));
            else 
                return gfp.nonzero(a);
        }
    }
}