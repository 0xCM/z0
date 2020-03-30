//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;
    using static As;

    partial class Numeric
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
                 return Z0.Scalar.nonz(uint8(a));
            else if(typeof(T) == typeof(ushort))
                 return Z0.Scalar.nonz(uint16(a));
            else if(typeof(T) == typeof(uint))
                 return Z0.Scalar.nonzero(uint32(a));
            else if(typeof(T) == typeof(ulong))
                 return Z0.Scalar.nonz(uint64(a));
            else 
                return nonz_i(a);
        }

        [MethodImpl(Inline)]
        static bit nonz_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return Z0.Scalar.nonz(int8(a));
            else if(typeof(T) == typeof(short))
                 return Z0.Scalar.nonz(int16(a));
            else if(typeof(T) == typeof(int))
                 return Z0.Scalar.nonzero(int32(a));
            else if(typeof(T) == typeof(long))
                 return Z0.Scalar.nonzero(int64(a));
            else 
                return nonz_f(a);
        }
    
        [MethodImpl(Inline)]
        static bit nonz_f<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return Z0.Scalar.nonz(float32(a));
            else if(typeof(T) == typeof(double))
                return Z0.Scalar.nonz(float64(a));
            else            
                throw Unsupported.define<T>();
        }    
    }

    partial class Scalar
    {
        [MethodImpl(Inline)]
        public static bit nonz(sbyte src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonz(byte src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonz(short src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonz(ushort src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(int src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(uint src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonzero(long src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonz(ulong src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bit nonz(float src)
            => src != 0;
            
        [MethodImpl(Inline)]
        public static bit nonz(double src)
            => src != 0;
    }            
}