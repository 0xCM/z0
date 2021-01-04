//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static WfEvents;

    partial interface IWfShell
    {
        WfExecFlow Processing<T>(FS.FilePath src, T data)
        {
            signal(this).Processing(src, data);
            return Flow();
        }

        void Processed<T>(WfExecFlow flow, FS.FilePath src, T data)
        {
            signal(this).Processed(src, data);
            Ran(flow);
        }

        void Processed<T,M>(WfExecFlow flow, FS.FilePath src, T data, M metric)
        {
            signal(this).Processed(src, data, metric);
            Ran(flow);
        }

        void Processed<T>(T content)
            => processed(Host, content, Ct);

        void Processed<T>(ApiHostUri uri, T content)
            => processed(Host, Seq.delimit(uri,content), Ct);

        void Created(WfStepId id)
        {
            if(Verbosity.IsBabble())
                Raise(created(id, Ct));
        }

        void Created()
            => Created(Host);

        void Created<H>(H host)
            where H : IWfHost<H>, new()
        {
            if(Verbosity.IsBabble())
                Raise(created(host.Id, Ct));
        }
    }
}