//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class gbits
    {
        /// <summary>
        /// Disables a sequence of bits starting at a specified index
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin clearing bits</param>
        /// <param name="count">The number of bits to clear</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T disable<T>(T src, byte index, byte count)
            where T : unmanaged
        {
            if(size<T>() == 1)
                return generic<T>(Bits.disable(uint8(src), index, count));
            else if (size<T>() == 2)
                return generic<T>(Bits.disable(uint16(src), index, count));
            else if (size<T>() == 4)
                return generic<T>(Bits.disable(uint32(src), index, count));
            else
                return generic<T>(Bits.disable(uint64(src), index, count));
        }

        /// <summary>
        /// Disables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline), Disable, Closures(AllNumeric)]
        public static T disable<T>(T src, int pos)
            where T : unmanaged
        {
            if(size<T>() == 1)
                 return generic<T>(Bits.disable(uint8(src), pos));
            else if (size<T>() == 2)
                 return generic<T>(Bits.disable(uint16(src), pos));
            else if (size<T>() == 4)
                 return generic<T>(Bits.disable(uint32(src), pos));
            else
                 return generic<T>(Bits.disable(uint64(src), pos));
        }
    }
}