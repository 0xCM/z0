//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    


    [ApiHost]
    public readonly partial struct EventHubs
    {
        [MethodImpl(Inline), Op]
        public static EventHub hub(int capacity = 128)
            => new EventHub(capacity);    
    }
}