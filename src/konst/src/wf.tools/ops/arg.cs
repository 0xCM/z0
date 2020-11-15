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
        [MethodImpl(Inline), Factory]
        public static ToolArg arg(ToolOption option, string value)
            => new ToolArg(option,value);

        [MethodImpl(Inline), Factory]
        public static ToolArg arg(string option, string value)
            => new ToolArg(option,value);

        [MethodImpl(Inline)]
        public static ToolArg<K,V> arg<K,V>(K key, V value)
            where K : unmanaged
                => new ToolArg<K,V>(key,value);
    }
}