//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static As;
    using static Seed;

    partial class Numeric
    {
        /// <summary>
        /// If the source value is signed, negates it; otherwise, computes
        /// the two's complement negation
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Two%27s_complement</remarks>
        [MethodImpl(Inline)]
        public static T negate<T>(T src)
            where T : unmanaged
            => negate_u(src);
            
        [MethodImpl(Inline)]
        static T negate_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Z0.Scalar.negate(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Z0.Scalar.negate(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Z0.Scalar.negate(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Z0.Scalar.negate(uint64(src)));
            else
                return negate_i(src);
        }

        [MethodImpl(Inline)]
        static T negate_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Z0.Scalar.negate(int8(src)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Z0.Scalar.negate(int16(src)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Z0.Scalar.negate(int32(src)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(Z0.Scalar.negate(int64(src)));
            else 
                return negate_f(src);
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        static T negate_f<T>(T lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(Z0.Scalar.negate(float32(lhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Z0.Scalar.negate(float64(lhs)));
            else            
                throw Unsupported.define<T>();
        }
    }

    partial class Scalar
    {
        [MethodImpl(Inline)]
        public static sbyte negate(sbyte src)
            => (sbyte)(- src);

        [MethodImpl(Inline)]
        public static byte negate(byte src)
            => (byte)(~src + 1);

        [MethodImpl(Inline)]
        public static short negate(short src)
            => (short)(- src);

        [MethodImpl(Inline)]
        public static ushort negate(ushort src)
            => (ushort)(~src + 1);

        [MethodImpl(Inline)]
        public static int negate(int src)
            => -src;

        [MethodImpl(Inline)]
        public static uint negate(uint src)
            => ~src + 1;

        [MethodImpl(Inline)]
        public static long negate(long src)
            => -src;

        [MethodImpl(Inline)]
        public static ulong negate(ulong src)
            => ~src + 1;

        [MethodImpl(Inline)]
        public static float negate(float src)
            => -src;

        [MethodImpl(Inline)]
        public static double negate(double src)
            => -src;        
    }
}