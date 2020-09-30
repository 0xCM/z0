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

    public abstract class WfHost<H,S,T> : WfHost<H>, IWfHost<H,S,T>
        where H : WfHost<H,S,T>, new()
        where S : new()
    {
        [MethodImpl(Inline)]
        protected WfHost()
            : base()
        {

        }

        [MethodImpl(Inline)]
        public void Run(IWfShell wf, in S src)
            => Run(wf,src, out var _);

        [MethodImpl(Inline)]
        public ref T Run(IWfShell wf, in S src, out T dst)
        {
            Execute(wf, src, out dst);
            return ref dst;
        }

        protected abstract ref T Execute(IWfShell wf, in S src, out T dst);
    }
}