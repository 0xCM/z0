//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    public ref struct Unity
    {
        readonly IWfShell Wf;

        public readonly WfStepId Id;

        Unity(IWfShell wf)
        {
            Wf = wf;
            Id = typeof(Unity);
            Wf.Created(Id);
        }

        public static Unity Init(IWfShell wf)
            => new Unity(wf);

        public void Run()
        {
            Wf.Running(Id);


            Wf.Ran(Id);
        }

        public void Dispatch()
        {

        }

        public void Dispose()
        {
            Wf.Disposed(Id);
        }
    }
}
