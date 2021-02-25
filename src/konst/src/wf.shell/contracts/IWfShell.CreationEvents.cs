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
        void Created()
        {
            if(Verbosity.IsBabble())
                Raise(created(Host.Id, Ct));
        }

        void Disposed()
        {
            if(Verbosity.IsBabble())
                Raise(disposed(Host.Id, Ct));
        }

        WfExecFlow<T> Creating<T>(T data)
        {
            signal(this).Creating(data);
            return Flow(data);
        }

        WfExecToken Created<T>(WfExecFlow<T> flow)
        {
            signal(this).Created(flow.Data);
            return Ran(flow);
        }
    }
}