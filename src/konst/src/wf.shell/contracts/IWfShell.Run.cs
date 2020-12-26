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
        WfExecFlow Running()
        {
            signal(this).Running();
            return Flow();
        }

        WfExecFlow Running<T>(T data, [Caller] string caller = null)
        {
            signal(this).Running(data);
            return Flow();
        }

        WfExecFlow Running(WfHost host, [Caller] string caller = null)
        {
            signal(this).Running(host);
            return Flow();
        }

        WfExecFlow Running<T>(WfHost host, T data, [Caller] string caller = null)
        {
            signal(this).Running(host, data);
            return Flow();
        }

        void Ran(WfExecFlow flow, WfStepId step)
        {
            signal(this).Ran(step);
            Ran(flow);
            flow.Dispose();
        }

        void Ran<H,T>(WfExecFlow flow, H host, T data)
            where H : IWfHost<H>, new()
        {
            signal(this).Ran(data);
            Ran(flow);
            flow.Dispose();
        }

        void Ran<T>(WfExecFlow flow, T data)
        {
            signal(this).Ran(data);
            Ran(flow);
            flow.Dispose();
        }

        void Ran(WfExecFlow flow, CmdResult result)
        {
            signal(this).Ran(result);
            Ran(flow);
            flow.Dispose();
        }
    }
}