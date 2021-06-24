//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Cmd
    {
        [MethodImpl(Inline), Op]
        public static CmdFlag<T> flag<T>(string name, T value, ArgPrefix prefix)
            => new CmdFlag<T>(name, value, prefix);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdFlag<T> flag<T>(ushort pos, T value, ArgPrefix prefix)
            => new CmdFlag<T>(pos, value.ToString(), value, prefix);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static CmdFlag<T> flag<T>(ushort pos, string name, T value, ArgPrefix prefix)
            => new CmdFlag<T>(pos, name, value, prefix);
    }
}