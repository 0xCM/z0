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

    partial struct Cmd
    {
        /// <summary>
        /// Creates a <see cref='ToolSpec'/>
        /// </summary>
        /// <param name="tool">The tool identifier</param>
        /// <param name="flags"></param>
        [MethodImpl(Inline), Op]
        public static ToolSpec tool(ToolId tool, ToolFlag[] flags)
            => new ToolSpec(tool,flags);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolSpec tool<T>(ToolFlag[] flags)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags);

        [MethodImpl(Inline)]
        public static ToolSpec tool<T,F>(F[] flags, CmdArg[] options, T tool = default)
            where T : unmanaged
            where F : unmanaged
                => new ToolSpec(typeof(T).Name, flags.Map(f => Tooling.flag(f.ToString())));
    }
}