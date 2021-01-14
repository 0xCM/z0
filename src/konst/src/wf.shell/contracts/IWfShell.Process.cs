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

        WfExecToken Processed<T>(WfExecFlow flow, FS.FilePath src, T data)
        {
            signal(this).Processed(src, data);
            return Ran(flow);
        }

        WfExecToken Processed<T,M>(WfExecFlow flow, FS.FilePath src, T data, M metric)
        {
            signal(this).Processed(src, data, metric);
            return Ran(flow);
        }

        void Processed<T>(T content)
        {
            signal(this).Processed(content);
        }

        void Processed<T>(ApiHostUri uri, T content)
        {
            signal(this).Processed(uri,content);

        }

        WfExecToken Processed<T>(WfExecFlow flow, T content)
        {
            signal(this).Processed(content);
            return Ran(flow);
        }

        WfExecToken Processed<T>(WfExecFlow flow, ApiHostUri uri, T content)
        {
            signal(this).Processed(uri,content);
            return Ran(flow);
        }

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