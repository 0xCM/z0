//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static WfEvents;

    partial interface IWfShell
    {
        WfExecFlow Creating<T>(T data)
        {
            signal(this).Creating(data);
            return Flow();
        }

        WfExecToken Created<T>(WfExecFlow flow, T data)
        {
            signal(this).Created(data);
            return Ran(flow);
        }
    }
}