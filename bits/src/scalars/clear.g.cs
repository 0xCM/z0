//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Clears a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="first">The position of the first bit to clear</param>
        /// <param name="last">The position of the last bit to clear</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T clear<T>(T src, int first, int last)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.clear(uint8(src), first, last));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.clear(uint16(src), first, last));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.clear(uint32(src), first, last));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(Bits.clear(uint64(src), first, last));
            else
                throw unsupported<T>();
        }



    }

}