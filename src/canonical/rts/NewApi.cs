//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static Konst;    

    [ApiHost]
    public readonly struct NewApi
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static MemoryAddress ptr<T>(T[] src, int index)
            => Marshal.UnsafeAddrOfPinnedArrayElement(src,index);
    }
}