//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ToolCmd
    {
        [MethodImpl(Inline), Op]
        public static ToolFlagArg<T> flag<T>(string name, T value, ArgPrefix prefix)
            => new ToolFlagArg<T>(name, value, prefix);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolFlagArg<T> flag<T>(ushort pos, T value, ArgPrefix prefix)
            => new ToolFlagArg<T>(pos, value.ToString(), value, prefix);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolFlagArg<T> flag<T>(ushort pos, string name, T value, ArgPrefix prefix)
            => new ToolFlagArg<T>(pos, name, value, prefix);
    }
}