//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct WfExecFlow : IDisposable
    {
        readonly IWfShell Wf;

        public WfExecToken Token {get;}

        [MethodImpl(Inline)]
        internal WfExecFlow(IWfShell wf, in WfExecToken token)
        {
            Wf = wf;
            Token = token;
        }

        public void Dispose()
            => Wf.Ran(this);
    }
}