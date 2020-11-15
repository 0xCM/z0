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

    public abstract class CmdNode<H,S,T> : ICmdNode<H,S,T>
        where H : CmdNode<H,S,T>, new()
        where S : struct, ICmdSpec<S>
        where T : struct
    {
        protected IWfShell Wf;

        protected static S Spec() => new S();

        public CmdId CmdId => Spec().Id;

        public static H Node(IWfShell wf)
        {
            var node = new H();
            node.Init(wf);
            return node;
        }

        protected abstract T Run(S cmd);

        public T Process(S cmd)
        {
            return Run(cmd);
        }

        public void Init(IWfShell wf)
            => Wf = wf;
    }
}