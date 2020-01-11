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
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
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
                 return generic<T>(BitMask.toggle(int8(src), pos));
            else if(typeof(T) == typeof(short))
                 return generic<T>(BitMask.toggle(int16(src), pos));
            else if(typeof(T) == typeof(int))
                 return generic<T>(BitMask.toggle(int32(src), pos));
            else 
                 return generic<T>(BitMask.toggle(int64(src), pos));
        }

        [MethodImpl(Inline)]
        static T toggle_u<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(BitMask.toggle(uint8(src), pos));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(BitMask.toggle(uint16(src), pos));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(BitMask.toggle(uint32(src), pos));
            else 
                 return generic<T>(BitMask.toggle(uint64(src), pos));
        }

        [MethodImpl(Inline)]
        static T toggle_f<T>(T src, int pos)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(BitMask.toggle(float32(src), pos));
            else if(typeof(T) == typeof(double))
                 return generic<T>(BitMask.toggle(float64(src), pos));
            else
                throw unsupported<T>();
        }
 
         /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static sbyte toggle(sbyte src, int pos)
            => src ^= (sbyte)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static byte toggle(byte src, int pos)
            => src ^= (byte)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static short toggle(short src, int pos)
            => src ^= (short)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static ushort toggle(ushort src, int pos)
            => src ^= (ushort)(1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static int toggle(int src, int pos)
            => src ^= (1 << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static uint toggle(uint src, int pos)
            => src ^= (1u << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static long toggle(long src, int pos)
            => src ^= (1L << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static ulong toggle(ulong src, int pos)
            => src ^= (1ul << pos);

        /// <summary>
        /// Flips an identified source bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The position of the bit to toggle</param>
        [MethodImpl(Inline)]
        internal static float toggle(float src, int pos)
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
        internal static double toggle(double src, int pos)
        {
            ref var bits = ref Unsafe.As<double,long>(ref src);
            bits ^= (1L << pos);
            return src;
        }
    }

}