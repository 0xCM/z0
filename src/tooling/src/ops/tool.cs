//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ToolCmd
    {
        /// <summary>
        /// Creates a <see cref='ToolSpec'/>
        /// </summary>
        /// <param name="tool">The tool identifier</param>
        /// <param name="verbs"></param>
        [MethodImpl(Inline), Op]
        public static ToolSpec tool(ToolId tool, ToolFlagSpec[] flags, ToolOptionSpec[] options, ToolUsage syntax)
            => new ToolSpec(tool, flags, options, syntax);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolSpec tool<T>(ToolFlagSpec[] flags, ToolOptionSpec[] options, ToolUsage syntax)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, flags, options, syntax);
    }
}