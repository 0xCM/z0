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
        public static ToolSpec specify(string tool, ToolFlag[] flags, ToolOption[] options)
            => new ToolSpec(tool,flags,options);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ToolSpec specify<T>(ToolFlag[] flags, ToolOption[] options)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags,options);

        [MethodImpl(Inline)]
        public static ToolSpec specify<T,F>(F[] flags, ToolOption[] options, T tool = default)
            where T : unmanaged
            where F : unmanaged
                => new ToolSpec(typeof(T).Name, flags.Map(f => flag(f.ToString())), options);
    }
}