//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst; 
    using static Memories;

    partial class gmath
    {
        /// <summary>
        /// Computes the sign of a primal operand
        /// </summary>
        /// <param name="a">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Sign signum<T>(T a)
            where T : unmanaged
                => signum_u(a);

        [MethodImpl(Inline)]
        static Sign signum_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.signum(uint8(a));
            else if(typeof(T) == typeof(ushort))
                return math.signum(uint16(a));
            else if(typeof(T) == typeof(uint))
                return math.signum(uint32(a));
            else if(typeof(T) == typeof(ulong))
                return math.signum(uint64(a));
            else
                return signum_i(a);
       }           

        [MethodImpl(Inline)]
        static Sign signum_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.signum(int8(a));
            else if(typeof(T) == typeof(short))
                return math.signum(int16(a));
            else if(typeof(T) == typeof(int))
                return math.signum(int32(a));
            else if(typeof(T) == typeof(long))
                return math.signum(int64(a));
            else
                return gfp.signum(a);
        }        
    }
}