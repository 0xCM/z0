//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WfEvents;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    partial interface IWfRuntime
    {
        WfExecFlow<string> Running([Caller] string operation = null)
        {
            signal(this).Running(operation);
            return Flow(operation);
        }

        WfExecFlow<T> Running<T>(T data, [Caller] string operation = null)
        {
            signal(this).Running(operation, data);
            return Flow(data);
        }

        ExecToken Ran(WfExecFlow src);

        ExecToken Ran<T>(WfExecFlow<T> src);

        ExecToken Ran<T,D>(WfExecFlow<T> flow, D data);
    }
}