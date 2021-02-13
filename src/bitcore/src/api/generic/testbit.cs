//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static bit testbit<T,I>(T src, I index)
            where T : unmanaged
            where I : unmanaged
                => testbit<T>(src, memory.u8(index));

        /// <summary>
        /// Returns 1 if an index-identified bit is enabled, false otherwise
        /// </summary>
        /// <param name="src">The value to test</param>
        /// <param name="pos">The bit index to check</param>
        [MethodImpl(Inline), TestBit, Closures(AllNumeric)]
        public static bit testbit<T>(T src, byte pos)
            where T : unmanaged
        {
            if(size<T>() == 1)
                 return Bits.testbit(uint8(src), pos);
            else if(size<T>() == 2)
                 return Bits.testbit(uint16(src), pos);
            else if(size<T>() == 4)
                 return Bits.testbit(uint32(src), pos);
            else
                return Bits.testbit(uint64(src), pos);
        }
    }
}