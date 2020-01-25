//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {    
        /// <summary>
        /// Disables a sequence of bits starting at a specified index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin clearing bits</param>
        /// <param name="count">The number of bits to clear</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static T bitclear<T>(T src, byte index, byte count)
            where T : unmanaged
                => bitclear_u(src,index,count);

        [MethodImpl(Inline)]
        static T bitclear_u<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.bitclear(uint8(src), index, count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.bitclear(uint16(src), index, count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.bitclear(uint32(src), index, count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.bitclear(uint64(src), index, count));
            else
                return bitclear_i(src,index,count);
        }

        [MethodImpl(Inline)]
        static T bitclear_i<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.bitclear(int8(src), index, count));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.bitclear(int16(src), index, count));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.bitclear(int32(src), index, count));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.bitclear(int64(src), index, count));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Disables a sequence of 8 source bits starting at a specified index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin clearing bits</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static T clearbyte<T>(T src, byte index)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return default;
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.clearbyte(uint16(src), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.clearbyte(uint32(src), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.clearbyte(uint64(src), index));
            else
                throw unsupported<T>();
        }

    }
}