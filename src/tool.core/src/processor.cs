//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Tooling
    {
        [MethodImpl(Inline)]
        public static ToolProcessor<T,F> processor<T,F>(IWfShell wf, Action<IToolFile<T,F>> handler)
            where T : struct, ITool<T,F>
            where F : unmanaged, Enum
                => new ToolProcessor<T,F>(wf, handler);
    }
}