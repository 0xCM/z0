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
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static T log2<T>(in T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.log2(AsIn.uint8(in asRef(in src))));
            else if(typematch<T,ushort>())
                 return generic<T>(Bits.log2(AsIn.uint16(in asRef(in src))));
            else if(typematch<T,uint>())
                 return generic<T>(Bits.log2(AsIn.uint32(in asRef(in src))));
            else if(typematch<T,ulong>())
                 return generic<T>(Bits.log2(AsIn.uint64(in asRef(in src))));
            else 
                throw unsupported<T>();
        }

    }

}