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

    partial class Numeric
    {

        /// <summary>
        /// Returns 1 if the source operand is non-zero and 0 otherwise
        /// </summary>
        /// <param name="a">The source operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        internal static bit nonz<T>(T a)
            where T : unmanaged
                => nonz_u(a);

        [MethodImpl(Inline)]
        static bit nonz_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return Scalar.nonz(uint8(a));
            else if(typeof(T) == typeof(ushort))
                 return Scalar.nonz(uint16(a));
            else if(typeof(T) == typeof(uint))
                 return Scalar.nonzero(uint32(a));
            else if(typeof(T) == typeof(ulong))
                 return Scalar.nonz(uint64(a));
            else 
                return nonz_i(a);
        }

        [MethodImpl(Inline)]
        static bit nonz_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return Scalar.nonz(int8(a));
            else if(typeof(T) == typeof(short))
                 return Scalar.nonz(int16(a));
            else if(typeof(T) == typeof(int))
                 return Scalar.nonzero(int32(a));
            else if(typeof(T) == typeof(long))
                 return Scalar.nonzero(int64(a));
            else 
                return nonz_f(a);
        }
    
        [MethodImpl(Inline)]
        static bit nonz_f<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return Scalar.nonz(float32(a));
            else if(typeof(T) == typeof(double))
                return Scalar.nonz(float64(a));
            else            
                throw Unsupported.define<T>();
        }    
    }
}