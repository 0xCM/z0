//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static AsmRegs;

    public class CpuModel
    {
        readonly IWfRuntime Wf;

        readonly Stack<ulong> CallStack;

        public static CpuModel create(IWfRuntime wf)
            => new CpuModel(wf);

        CpuModel(IWfRuntime wf)
        {
            Wf = wf;
        }

        public void push(r64 r)
        {
            CallStack.Push(r.Content);
        }
    }
}