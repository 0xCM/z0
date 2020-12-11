//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct CmdTools
    {
        [MethodImpl(Inline), Factory]
        public static CmdToolArg arg(CmdOptionSpec option, ushort position, string value)
            => new CmdToolArg(option, position, value);

        [MethodImpl(Inline), Factory]
        public static CmdToolArg<T> arg<T>(CmdOptionSpec option, ushort position, T value)
            => new CmdToolArg<T>(option, position, value);

        [MethodImpl(Inline)]
        public static CmdToolArg<K,V> arg<K,V>(CmdOptionSpec<K> option, ushort position, V value)
            where K : unmanaged
                => new CmdToolArg<K,V>(option, position, value);
    }
}