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
        public static ToolArg arg(ushort position, CmdArgProtocol protocol, CmdOption option, string value)
            => new ToolArg(position, protocol, option,value);

        [MethodImpl(Inline), Factory]
        public static ToolArg<T> arg<T>(ushort position, CmdArgProtocol protocol, CmdOption option, T value)
            => new ToolArg<T>(position, protocol, option, value);

        [MethodImpl(Inline)]
        public static ToolArg<K,V> arg<K,V>(ushort position, CmdArgProtocol protocol, K option, V value)
            where K : unmanaged
                => new ToolArg<K,V>(position, protocol, option, value);
    }
}