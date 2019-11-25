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
        [MethodImpl(Inline)]
        public static T inject<T>(T src, T dst, int start, int length)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.inject(uint8(src), uint8(dst), start, length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.inject(uint16(src), uint16(dst), start, length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.inject(uint32(src), uint32(dst), start, length));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.inject(uint64(src), uint64(dst), start, length));
            else
                throw unsupported<T>();
        }           


    }
}