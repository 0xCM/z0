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
        public ToolVerb verb(ToolId tool, string name)
            => new ToolVerb(tool,name);

        [MethodImpl(Inline), Op]
        public static ToolVerb verb<T>(string name)
            where T : struct, ITool<T>
                => new ToolVerb(toolid<T>(), name);
    }
}