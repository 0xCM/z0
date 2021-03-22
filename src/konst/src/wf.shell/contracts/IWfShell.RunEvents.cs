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

        WfExecToken Ran(WfExecFlow src);

        WfExecToken Ran<T>(WfExecFlow<T> src);

        WfExecToken Ran<T,D>(WfExecFlow<T> flow, D data);

    }
}