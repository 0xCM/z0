//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        [MethodImpl(Inline)]   
        public static ulong uint64<T>(T src)
            => As.uint64(src);
     
        [MethodImpl(Inline)]   
        public static ulong? uint64<T>(T? src)
            where T : unmanaged                
                => As.uint64(src);
    }
}