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

    public readonly struct WfTableFlow<T>
        where T : struct, IRecord<T>
    {
        readonly IWfShell Wf;

        public WfExecToken Token {get;}

        public FS.FilePath Target {get;}

        public Count EmissionCount {get;}

        [MethodImpl(Inline)]
        internal WfTableFlow(IWfShell wf, FS.FilePath dst, in WfExecToken token, uint count = 0)
        {
            Wf = wf;
            Token = token;
            Target = dst;
            EmissionCount = count;
        }

        [MethodImpl(Inline)]
        public WfTableFlow<T> WithCount(Count count)
            => new WfTableFlow<T>(Wf, Target, Token, count);

        [MethodImpl(Inline)]
        public static implicit operator WfExecFlow<T>(WfTableFlow<T> src)
            => new WfExecFlow<T>(src.Wf, src.Token);

        [MethodImpl(Inline)]
        public static implicit operator WfExecFlow(WfTableFlow<T> src)
            => new WfExecFlow(src.Wf, src.Token);
    }
}