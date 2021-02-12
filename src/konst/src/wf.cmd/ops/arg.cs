//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cmd
    {
        [MethodImpl(Inline), Op]
        public static CmdArg<T> arg<T>(string name, T value)
            => new CmdArg<T>(name, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg<T> arg<T>(ushort pos, T value)
            => new CmdArg<T>(pos, value);

        [MethodImpl(Inline), Op]
        public static CmdArg<T> arg<T>(ushort pos, string name, T value, ArgPrefix prefix)
            => new CmdArg<T>(pos, name, value, prefix);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg<T> arg<T>(ushort pos, string name, T value, ArgPrefix prefix, ArgQualifier qualifier)
            => new CmdArg<T>(pos, name, value, (prefix, qualifier));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdArg<T> arg<T>(ushort pos, string name, T value, ArgProtocol protocol)
            => new CmdArg<T>(pos, name, value, protocol);

        [MethodImpl(Inline)]
        public static CmdArg<K,T> arg<K,T>(K kind, T value)
            where K : unmanaged
                => new CmdArg<K,T>(kind,value);
    }
}