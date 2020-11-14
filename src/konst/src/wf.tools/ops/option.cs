//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Tooling
    {
        [MethodImpl(Inline), Op]
        public static ToolOption option(string key, string value)
            => new ToolOption(key,value);

        [MethodImpl(Inline)]
        public static ToolOption<K,V> option<K,V>(K key, V value)
            where K : unmanaged
                => new ToolOption<K,V>(key,value);
    }
}