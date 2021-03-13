//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong read64<T>(in T src)
        {
            if(size<T>() >= 64)
                return u64(src);
            else  if(size<T>() >= 32)
                return u32(src);
            else  if(size<T>() >= 16)
                return u16(src);
            else
                return u8(src);
        }
    }
}