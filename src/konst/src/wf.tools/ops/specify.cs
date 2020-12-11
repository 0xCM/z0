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

    partial struct CmdTools
    {
        /// <summary>
        /// Creates a <see cref='ToolSpec'/>
        /// </summary>
        /// <param name="tool">The tool identifier</param>
        /// <param name="verbs"></param>
        [MethodImpl(Inline), Op]
        public static ToolSpec specify(ToolId tool, CmdFlagSpec[] flags, CmdOptionSpec[] options, UsageSyntax syntax)
            => new ToolSpec(tool, flags, options, syntax);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolSpec specify<T>(CmdFlagSpec[] flags, CmdOptionSpec[] options, UsageSyntax syntax)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags, options, syntax);

    }
}