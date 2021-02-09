//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    using static WfEvents;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    partial interface IWfShell
    {
        // WfExecFlow Running()
        // {
        //     signal(this).Running();
        //     return Flow();
        // }

        WfExecFlow Running([Caller] string operation = null)
        {
            signal(this).Running(operation);
            return Flow();
        }

        WfExecFlow Running<T>(string operation, T data)
        {
            signal(this).Running(operation, data);
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

        WfExecFlow Running<T>(ICmd<T> cmd)
            where T : struct, ICmd<T>
        {
            signal(this).Running(cmd);
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

        WfExecToken Ran(WfExecFlow flow, CmdResult result)
        {
            signal(this).Ran(result);
            return Ran(flow);
        }

        WfExecToken Ran<C>(WfExecFlow flow, CmdResult<C> result)
            where C : struct, ICmd<C>
        {
            signal(this).Ran(result);
            return Ran(flow);
        }
    }
}