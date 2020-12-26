//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static WfEvents;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    partial interface IWfShell
    {
        void SignalRunning()
            => Raise(running(Host, Ct));

        void SignalRunning(WfHost host)
            => Raise(running(host, Ct));

        void SignalRunning<T>(WfHost host, T data)
            => Raise(running(host, data, Ct));

        void SignalRunning<T>(T src)
            => Raise(running(Host, src, Ct));

        WfExecFlow Running()
        {
            SignalRunning();
            return Flow();
        }

        WfExecFlow Running<T>(T data, [Caller] string caller = null)
        {
            SignalRunning(data);
            return Flow();
        }

        WfExecFlow Running(WfHost host, [Caller] string caller = null)
        {
            SignalRunning(host);
            return Flow();
        }

        WfExecFlow Running<T>(WfHost host, T data, [Caller] string caller = null)
        {
            SignalRunning(host,data);
            return Flow();
        }

        void Ran()
            => signal(this).Ran();

        void Ran(WfStepId step)
        {
            signal(this).Ran(step);
        }

        void Ran(WfExecFlow flow, WfStepId step)
        {
            signal(this).Ran(step);
            Ran(flow);
        }

        void Ran<H,T>(H host, T data)
            where H : IWfHost<H>, new()
                => Raise(ran(host, data, Ct));

        void Ran2<T>(T data)
            => signal(this).Ran(data);

        void Ran(CmdResult cmd)
        {
            signal(this).Ran(cmd);
        }

        void Ran<T>(WfExecFlow flow, T data)
        {
            signal(this).Ran(data);
            Ran(flow);
        }

        void Ran(WfExecFlow flow, CmdResult result)
        {
            signal(this).Ran(result);
            Ran(flow);
        }
    }
}