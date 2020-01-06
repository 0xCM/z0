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
        [MethodImpl(Inline), ZFunc(PrimalKind.U16 | PrimalKind.U32 | PrimalKind.U64)]
        public static T byteswap<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.byteswap(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.byteswap(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.byteswap(uint64(src)));
            else
                throw unsupported<T>();
        }
    }

}