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
    using static WfEvents;

    partial class WfShell
    {
        long SourceToken;

        long TargetToken;

        WfExecTokens ExecTokens {get;}
            = WfExecTokens.init();

        void SignalRunning()
            => Wf.Raise(running(Host, Ct));

        void SignalRunning<T>(T src)
            => Wf.Raise(running(Host, src, Ct));

        public void SignalRan()
            => Wf.Raise(new RanEvent(Host, Ct));

        public void SignalTableEmitting(Type type, FS.FilePath dst)
            => Wf.Raise(tableEmitting(Host, type, dst, Ct));

        public WfExecFlow Running<T>(T src)
        {
            SignalRunning(src);
            return Flow();
        }

        public WfExecFlow EmittingTable(Type type, FS.FilePath dst)
        {
            SignalTableEmitting(type, dst);
            return new WfExecFlow(this, NextExecToken());
        }

        public WfExecFlow Running()
        {
            SignalRunning();
            return Flow();
        }

        public WfExecToken Ran(WfExecFlow src)
        {
            SignalRan();
            var token = CloseExecToken(src.Token);
            ExecTokens.TryAdd(token.Source, token);
            return token;
        }

        public void Ran()
            => SignalRan();

        [MethodImpl(Inline)]
        WfExecToken NextExecToken()
            => new WfExecToken((ulong)atomic(ref SourceToken));

        [MethodImpl(Inline)]
        WfExecToken CloseExecToken(in WfExecToken src)
            => src.WithTarget((ulong)atomic(ref TargetToken));

        [MethodImpl(Inline)]
        WfExecFlow Flow()
            => new WfExecFlow(this, NextExecToken());
    }
}