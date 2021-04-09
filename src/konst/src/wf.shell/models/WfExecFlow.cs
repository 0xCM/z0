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
        readonly IWfRuntime Wf;

        public WfExecToken Token {get;}

        [MethodImpl(Inline)]
        internal WfExecFlow(IWfRuntime wf, in WfExecToken token)
        {
            Wf = wf;
            Token = token;
        }

        public void Dispose()
            => Wf.Ran(this);
    }

    public readonly struct WfExecFlow<T>: IDisposable
    {
        readonly IWfRuntime Wf;

        public T Data {get;}

        public WfExecToken Token {get;}

        [MethodImpl(Inline)]
        internal WfExecFlow(IWfRuntime wf, T data, in WfExecToken token)
        {
            Wf = wf;
            Data = data;
            Token = token;
        }

        public void Dispose()
            => Wf.Ran(this);
    }
}