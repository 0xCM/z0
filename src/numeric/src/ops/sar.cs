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
        /// Applies an arithmetic left-shift to an integer
        /// </summary>
        /// <param name="src">The value to shift</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline)]
        public static T sar<T>(T src, byte offset)
            where T : unmanaged
                => sar_u(src,offset);

        [MethodImpl(Inline)]
        static T sar_u<T>(T src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Scalar.sar(uint8(src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Scalar.sar(uint16(src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Scalar.sar(uint32(src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Scalar.sar(uint64(src), offset));
            else
                return sar_i(src,offset);
        }

        [MethodImpl(Inline)]
        static T sar_i<T>(T src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Scalar.sar(int8(src), offset));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Scalar.sar(int16(src), offset));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Scalar.sar(int32(src), offset));
            else if(typeof(T) == typeof(long))
                 return generic<T>(Scalar.sar(int64(src), offset));
            else
                throw Unsupported.define<T>();
        }
    }

    partial class Scalar
    {
        [MethodImpl(Inline)]
        public static sbyte sar(sbyte src, byte offset)
            =>(sbyte)(src >> offset);

        [MethodImpl(Inline)]
        public static byte sar(byte src, byte offset)
            => (byte)(src >> offset);

        [MethodImpl(Inline)]
        public static short sar(short src, byte offset)
            => (short)(src >> offset);

        [MethodImpl(Inline)]
        public static ushort sar(ushort src, byte offset)
            => (ushort)(src >> offset);

        [MethodImpl(Inline)]
        public static int sar(int src, byte offset)
            => src >> offset;

        [MethodImpl(Inline)]
        public static uint sar(uint src, byte offset)
            => src >> offset;

        [MethodImpl(Inline)]
        public static long sar(long src, byte offset)
            => src >> offset;

        [MethodImpl(Inline)]
        public static ulong sar(ulong src, byte offset)
            => src >> offset;             
    }    
}