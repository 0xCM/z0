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
        public static CmdArg<T> arg<T>(ushort index, T value)
            => (index,value);

        [MethodImpl(Inline), Op]
        public static CmdArg<T> arg<T>(ushort index, string name, T value)
            => new CmdArg<T>(index, name, value);
    }
}