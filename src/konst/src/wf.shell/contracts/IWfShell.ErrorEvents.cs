//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static WfEvents;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial interface IWfShell
    {
        void Error(WfStepId step, Exception e, [Caller] string caller = null, [File] string file = null, [Line]int? line = null)
        {
            signal(this).Error(step, e, WfEvents.originate("WorkflowError", caller, file, line));
        }

        void Error(Exception e, [Caller] string caller = null, [File] string file = null, [Line]int? line = null)
        {
            signal(this).Error(e, WfEvents.originate("WorkflowError", caller, file, line));
        }

        void Error<T>(T data, [Caller] string caller = null, [File] string file = null, [Line]int? line = null)
        {
            signal(this).Error(data, WfEvents.originate("WorkflowError", caller, file, line));
        }

        WfExecToken Error(WfExecFlow flow, Exception e, [Caller] string caller = null, [File] string file = null, [Line]int? line = null)
        {
            signal(this).Error(e, WfEvents.originate("WorkflowError", caller, file, line));
            return Ran(flow);
        }

        WfExecToken Error<T>(WfExecFlow<T> flow, Exception e, [Caller] string caller = null, [File] string file = null, [Line]int? line = null)
        {
            signal(this).Error(e, WfEvents.originate("WorkflowError", caller, file, line));
            return Ran(flow);
        }
    }
}