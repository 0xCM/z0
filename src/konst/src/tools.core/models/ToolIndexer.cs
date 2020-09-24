//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolIndexer
    {
        public IWfShell Wf {get;}

        public ToolIndexer(IWfShell wf)
        {
            Wf = wf;
        }

        public ToolIndex create()
        {

            return default;
        }
    }
}