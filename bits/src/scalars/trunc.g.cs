//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {

        /// <summary>
        /// Clears bits external to the segment [0..(len - 1)]
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="len">The count of lower bits that go unmolested</param>        
        [MethodImpl(Inline)]
        public static T trunc<T>(T src, byte len)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.trunc(uint8(src), len));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.trunc(uint16(src), len));
            else if(typematch<T,uint>())
                return generic<T>(Bits.trunc(uint32(src), len));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.trunc(uint64(src), len));
            else
                throw unsupported<T>();

        }


    }

}