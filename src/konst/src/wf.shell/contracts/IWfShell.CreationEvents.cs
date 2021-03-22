//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WfEvents;

    partial interface IWfShell
    {
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