//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct KeyMap<K,I>
        where K : unmanaged
        where I : unmanaged
    {
        public readonly K Key;

        public readonly I Index;

        [MethodImpl(Inline)]
        public KeyMap(K key, I pos)
        {
            Key = key;
            Index = pos;
        }
    }
}