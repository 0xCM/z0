//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;
    using static AsIn;

    partial class BitMask
    {        
        /// <summary>
        /// Inverts an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T toggle<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return toggle_u(src,pos);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return toggle_i(src,pos);
            else 
                return toggle_f(src,pos);            
        }

        [MethodImpl(Inline)]
        static T toggle_i<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(BitMask.flip(int8(src), pos));
            else if(typeof(T) == typeof(short))
                 return generic<T>(BitMask.flip(int16(src), pos));
            else if(typeof(T) == typeof(int))
                 return generic<T>(BitMask.flip(int32(src), pos));
            else 
                 return generic<T>(BitMask.flip(int64(src), pos));
        }

        [MethodImpl(Inline)]
        static T toggle_u<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(BitMask.flip(uint8(src), pos));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(BitMask.flip(uint16(src), pos));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(BitMask.flip(uint32(src), pos));
            else 
                 return generic<T>(BitMask.flip(uint64(src), pos));
        }

        [MethodImpl(Inline)]
        static T toggle_f<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(BitMask.flip(float32(src), pos));
            else if(typeof(T) == typeof(double))
                 return generic<T>(BitMask.flip(float64(src), pos));
            else
                throw unsupported<T>();
        }
 
         /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static sbyte flip(sbyte src, int pos)
            => src ^= (sbyte)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static byte flip(byte src, int pos)
            => src ^= (byte)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static short flip(short src, int pos)
            => src ^= (short)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static ushort flip(ushort src, int pos)
            => src ^= (ushort)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static int flip(int src, int pos)
            => src ^= (1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static uint flip(uint src, int pos)
            => src ^= (1u << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static long flip(long src, int pos)
            => src ^= (1L << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static ulong flip(ulong src, int pos)
            => src ^= (1ul << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static float flip(float src, int pos)
        {
            ref var bits = ref Unsafe.As<float,int>(ref src);
            bits ^= (1 << pos);
            return src;
        }

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static double flip(double src, int pos)
        {
            ref var bits = ref Unsafe.As<double,long>(ref src);
            bits ^= (1L << pos);
            return src;
        }
    }

}