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
        /// <summary>
        /// Creates a <see cref='ToolSpec'/>
        /// </summary>
        /// <param name="tool">The tool identifier</param>
        /// <param name="verbs"></param>
        [MethodImpl(Inline), Op]
        public static ToolSpec specify(ToolId tool, ToolVerb[] verbs)
            => new ToolSpec(tool,verbs);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ToolSpec specify<T>(ToolVerb[] verbs)
            where T : unmanaged
                => new ToolSpec(typeof(T).Name, verbs);

        [MethodImpl(Inline)]
        public static ToolSpec specify<T,F>(F[] flags, CmdArg[] options)
            where T : struct, ITool<T>
            where F : unmanaged
                => new ToolSpec(typeof(T).Name, flags.Map(f => Tooling.verb<T>(f.ToString())));
    }
}