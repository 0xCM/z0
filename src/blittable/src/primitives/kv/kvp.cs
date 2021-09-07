//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        public struct kvp<K,V>
            where K : unmanaged
            where V : unmanaged
        {
            public static ByteSize SZ => size<K>() + size<V>();

            public K Key;

            public V Val;

            [MethodImpl(Inline)]
            public kvp(K src, V dst)
            {
                Key =src;
                Val = dst;
            }

            public string Format()
                => Render.format(this);

            public override string ToString()
                => Format();

            public static implicit operator kvp<K,V>((K src, V dst) x)
                => new kvp<K,V>(x.src, x.dst);
        }
    }
}