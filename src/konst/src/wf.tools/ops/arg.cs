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
        public static ToolArg arg(CmdOptionSpec option, ushort position, string value)
            => new ToolArg(option, position, value);

        [MethodImpl(Inline), Factory]
        public static ToolArg<T> arg<T>(CmdOptionSpec option, ushort position, T value)
            => new ToolArg<T>(option, position, value);

        [MethodImpl(Inline)]
        public static ToolArg<K,V> arg<K,V>(CmdOptionSpec<K> option, ushort position, V value)
            where K : unmanaged
                => new ToolArg<K,V>(option, position, value);
    }
}