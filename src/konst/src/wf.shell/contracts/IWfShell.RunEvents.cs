//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static WfEvents;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    partial interface IWfShell
    {
        WfExecFlow Running([Caller] string operation = null)
        {
            signal(this).Running(operation);
            return Flow();
        }

        WfExecFlow<T> Running<T>(T data, [Caller] string operation = null)
        {
            signal(this).Running(operation, data);
            return Flow(data);
        }

        WfExecFlow Running(WfHost host, [Caller] string operation = null)
        {
            signal(this).Running(host);
            return Flow();
        }

        WfExecFlow Running<T>(WfHost host, T data, [Caller] string caller = null)
        {
            signal(this).Running(host, data);
            return Flow();
        }

        WfExecToken Ran<H,T>(WfExecFlow flow, H host, T data)
            where H : IWfHost<H>, new()
        {
            signal(this).Ran(data);
            return Ran(flow);
        }

        WfExecToken Ran<T>(WfExecFlow flow, T data)
        {
            signal(this).Ran(data);
            return Ran(flow);
        }

        WfExecToken Ran<T,D>(WfExecFlow<T> flow, D data)
        {
            signal(this).Ran(data);
            return Ran(flow);
        }
    }
}