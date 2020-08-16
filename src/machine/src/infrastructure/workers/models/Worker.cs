//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Worker : IWorker
    {
        [MethodImpl(Inline)]
        public void Process(IAsmOperands cmd, IWorkState state)
        {
            state.Handled(cmd);
        }
    }
}