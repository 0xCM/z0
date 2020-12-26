//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static WfEvents;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    partial interface IWfShell
    {
        void ProcessingFile<T>(FS.FilePath src, T kind)
        {
            if(Verbosity.Babble())
                Raise(new ProcessingFileEvent<T>(Host, kind, src, Ct));
        }

       void ProcessedFile<T>(FS.FilePath src, T kind)
            => Raise(fileProcessed(Host, src, kind, Ct));

        void ProcessedFile<T,M>(FS.FilePath src, T kind, M metric)
            => Raise(fileProcessed(Host, src, kind, metric, Ct));

        void Processed<T>(T content)
            => processed(Host, content, Ct);

        void Processed<T>(ApiHostUri uri, T content)
            => processed(Host, Seq.delimit(uri,content), Ct);


        void Created(WfStepId id)
        {
            if(Verbosity.Babble())
                Raise(created(id, Ct));
        }

        void Created()
            => Created(Host);

        void Created<H>(H host)
            where H : IWfHost<H>, new()
        {
            if(Verbosity.Babble())
                Raise(created(host.Id, Ct));
        }
    }
}