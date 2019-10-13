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

        [MethodImpl(Inline)]
        public static T rotl<T>(T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotl(uint8(src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotl(uint16(src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotl(uint32(src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotl(uint64(src), offset));
            else            
                throw unsupported<T>();
        }           



    }
}