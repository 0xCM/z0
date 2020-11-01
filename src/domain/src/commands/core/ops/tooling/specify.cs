//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Tooling
    {
        [MethodImpl(Inline), Op]
        public static ToolSpec specify(CmdToolId tool, ToolFlag[] flags)
            => new ToolSpec(tool,flags);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ToolSpec specify<T>(ToolFlag[] flags)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags);

        [MethodImpl(Inline)]
        public static ToolSpec specify<T,F>(F[] flags, CmdArg[] options, T tool = default)
            where T : unmanaged
            where F : unmanaged
                => new ToolSpec(typeof(T).Name, flags.Map(f => flag(f.ToString())));
    }
}