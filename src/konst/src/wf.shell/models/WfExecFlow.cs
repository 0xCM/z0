//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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

    public readonly struct WfExecFlow<T>: IDisposable
    {
        readonly IWfShell Wf;
        public Name Operation {get;}

        public T Data {get;}

        public WfExecToken Token {get;}

        [MethodImpl(Inline)]
        internal WfExecFlow(IWfShell wf, Name operation, T data, in WfExecToken token)
        {
            Wf = wf;
            Operation = operation;
            Data = data;
            Token = token;
        }

        public void Dispose()
            => Wf.Ran(this);
    }
}