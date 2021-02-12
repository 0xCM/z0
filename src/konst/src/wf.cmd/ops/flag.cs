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
        public static CmdFlagArg<T> flag<T>(string name, T value, ArgPrefix prefix)
            => new CmdFlagArg<T>(name, value, prefix);

        [MethodImpl(Inline), Op]
        public static CmdFlagArg<T> flag<T>(ushort pos, T value, ArgPrefix prefix)
            => new CmdFlagArg<T>(pos, value.ToString(), value, prefix);

        [MethodImpl(Inline), Op]
        public static CmdFlagArg<T> flag<T>(ushort pos, string name, T value, ArgPrefix prefix)
            => new CmdFlagArg<T>(pos, name, value, prefix);
    }
}