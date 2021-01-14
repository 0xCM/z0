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
        WfExecFlow Running()
        {
            signal(this).Running();
            return Flow();
        }

        WfExecFlow Running(string operation)
        {
            signal(this).Running(operation);
            return Flow();
        }

        WfExecFlow Running(MethodInfo operation)
        {
            signal(this).Running(operation.Name);
            return Flow();
        }

        WfExecFlow Running<T>(string operation, T data)
        {
            signal(this).Running(operation, data);
            return Flow();
        }

        WfExecFlow Running<T>(MethodInfo operation, T data)
        {
            signal(this).Running(operation.Name, data);
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

        WfExecToken Ran(WfExecFlow flow, WfStepId step)
        {
            signal(this).Ran(step);
            return Ran(flow);
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

        WfExecFlow Running<T>(ICmdSpec<T> cmd)
            where T : struct, ICmdSpec<T>
        {
            signal(this).Running(cmd);
            return Flow();
        }

        WfExecToken Ran(WfExecFlow flow, CmdResult result)
        {
            signal(this).Ran(result);
            return Ran(flow);
        }

        WfExecToken Ran<C>(WfExecFlow flow, CmdResult<C> result)
            where C : struct, ICmdSpec<C>
        {
            signal(this).Ran(result);
            return Ran(flow);
        }
    }
}