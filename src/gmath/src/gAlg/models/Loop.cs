//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Loop<K,T>
        where K : unmanaged
    {
        public K Min {get;}

        public K Max {get;}

        public K Step {get;}

        public Action<K,T> Receiver {get;}

        [MethodImpl(Inline)]
        public Loop(K min, K max, K step, Action<K,T> receiver)
        {
            Min = min;
            Max = max;
            Step = step;
            Receiver = receiver;
        }
    }
}