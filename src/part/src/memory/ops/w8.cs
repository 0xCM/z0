//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Conforms a source value as needed to yield a value of bit-width 8
        /// </summary>
        /// <param name="src">The input value</param>
        /// <typeparam name="T">The input type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static byte w8<T>(T src)
            where T : unmanaged
        {
            if(size<T>() == 8)
                return uint8(src);
            else if(size<T>() == 16)
                return (byte)uint16(src);
            else if(size<T>() == 32)
                return (byte)uint32(src);
            else
                return (byte)uint64(src);
        }

        /// <summary>
        /// Conforms a source value as needed to yield a value of bit-width 16
        /// </summary>
        /// <param name="src">The input value</param>
        /// <typeparam name="T">The input type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ushort w16<T>(T src)
            where T : unmanaged
        {
            if(size<T>() == 8)
                return uint8(src);
            if(size<T>() == 16)
                return uint16(src);
            else if(size<T>() == 32)
                return (ushort)uint32(src);
            else
                return (ushort)uint64(src);
        }

        /// <summary>
        /// Conforms a source value as needed to yield a value of bit-width 32
        /// </summary>
        /// <param name="src">The input value</param>
        /// <typeparam name="T">The input type</typeparam>

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint w32<T>(T src)
            where T : unmanaged
        {
            if(size<T>() == 8)
                return uint8(src);
            if(size<T>() == 16)
                return uint16(src);
            else if(size<T>() == 32)
                return uint32(src);
            else
                return (uint)uint64(src);
        }

        /// <summary>
        /// Conforms a source value as needed to yield a value of bit-width 64
        /// </summary>
        /// <param name="src">The input value</param>
        /// <typeparam name="T">The input type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ulong w64<T>(T src)
            where T : unmanaged
        {
            if(size<T>() == 8)
                return uint8(src);
            if(size<T>() == 16)
                return uint16(src);
            else if(size<T>() == 32)
                return uint32(src);
            else
                return uint64(src);
        }
    }
}