//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct Nasm : ITool<Nasm>
    {
        [MethodImpl(Inline)]
        public static Nasm tool(IEnvPaths paths)
            => new Nasm(paths);

        readonly IEnvPaths Paths;

        [MethodImpl(Inline)]
        Nasm(IEnvPaths paths)
            => Paths = paths;

        public ToolId Id => Toolsets.nasm;
    }
}