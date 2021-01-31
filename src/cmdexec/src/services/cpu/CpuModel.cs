//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;
    using static AsmDsl;

    public class CpuModel
    {
        readonly IWfShell Wf;

        readonly Stack<ulong> CallStack;

        public static CpuModel create(IWfShell wf)
            => new CpuModel(wf);

        CpuModel(IWfShell wf)
        {
            Wf = wf;
        }

        public void push(R64 r)
        {
            CallStack.Push(r);
        }
    }
}