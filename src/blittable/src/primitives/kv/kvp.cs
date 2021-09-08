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
        public static string format<S,T>(in kvp<S,T> m)
            where S : unmanaged
            where T : unmanaged
        {
            const string Pattern = "{0} -> {1}";
            return string.Format(Pattern, m.Key, m.Val);
        }

        [MethodImpl(Inline)]
        public static kvp<S,T> kv<S,T>(S src, T dst)
            where S : unmanaged
            where T : unmanaged
                => new kvp<S,T>(src,dst);


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
                => format(this);

            public override string ToString()
                => Format();

            public static implicit operator kvp<K,V>((K src, V dst) x)
                => new kvp<K,V>(x.src, x.dst);
        }
    }
}