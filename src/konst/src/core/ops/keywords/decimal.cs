//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                
        [MethodImpl(Inline)]
        public static unsafe decimal @decimal<T>(T src)
            where T : unmanaged             
                => *((decimal*)(&src));

        [MethodImpl(Inline), Op]
        public static unsafe decimal @decimal(bool on)
            => *((byte*)(&on));
    }
}