//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;
    using static WfShellUtility;
    using static WfEvents;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial interface IWfShell
    {
        void SignalTableEmitting(Type type, FS.FilePath dst)
            => Raise(tableEmitting(Host, type, dst, Ct));

        void SignalTableEmitting<T>(FS.FilePath dst)
            => Raise(tableEmitting<T>(Host, dst, Ct));

        WfExecFlow EmittingTable(Type type, FS.FilePath dst)
        {
            SignalTableEmitting(type, dst);
            return Flow();
        }

        WfExecFlow EmittingTable<T>(FS.FilePath dst)
            where T : struct
        {
            SignalTableEmitting<T>(dst);
            return Flow();
        }

        void EmittedTable<T>(WfStepId step, Count count, FS.FilePath dst)
            where T : struct
                => Raise(tableOut<T>(step, count, dst, Ct));

        void EmittedTable<T>(Count count, FS.FilePath dst, WfExecFlow flow)
            where T : struct
                => Raise(tableOut<T>(Host, count, dst, Ct));

        void EmittedTable<T>(Count count, FS.FilePath dst)
            where T : struct
                => Raise(tableOut<T>(Host, count, dst, Ct));

        void EmittedTable(Type type, Count count, FS.FilePath dst)
            => Raise(tableOut(Host, type, count, dst, Ct));

        void Ran()
            => SignalRan();

        WfExecFlow Flow()
            => new WfExecFlow(this, NextExecToken());

        void SignalRan()
            => Raise(new RanEvent(Host, Ct));

        void SignalRan<T>(T content)
            => Raise(ran(Host, content, Ct));


        void ProcessingFile<T>(FS.FilePath src, T kind)
        {
            if(Verbosity.Babble())
                Raise(new ProcessingFileEvent<T>(Host, kind, src, Ct));
        }

        void EmittingFile<T>(T source, FS.FilePath dst)
            => Raise(fileEmitting<T>(Host, source, dst, Ct));

        void EmittedFile<T>(T source, Count count, FS.FilePath dst)
            => Raise(fileOut(Host, source, count, dst, Ct));

        void EmittedFile(Count count, FS.FilePath dst)
            => Raise(fileOut(Host, dst, count, Ct));

       void ProcessedFile<T>(FS.FilePath src, T kind)
            => Raise(fileProcessed(Host, src, kind, Ct));

        void ProcessedFile<T,M>(FS.FilePath src, T kind, M metric)
            => Raise(fileProcessed(Host, src, kind, metric, Ct));


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