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

    partial class gbits
    {        
        /// <summary>
        /// Counts the number of leading zero bits the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int nlz<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return Bits.nlz(AsIn.uint8(src));
            else if(typeof(T) == typeof(ushort))
                 return Bits.nlz(AsIn.uint16(src));
            else if(typeof(T) == typeof(uint))
                 return Bits.nlz(AsIn.uint32(src));
            else if(typeof(T) == typeof(ulong))
                 return Bits.nlz(AsIn.uint64(src));
            else 
                throw unsupported<T>();
        }


    }

}