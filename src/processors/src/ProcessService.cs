//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public abstract class ProcessService : IProcessService
    {
        WfHost Host {get;}

        IEventSink Sink {get;}

        EventSignal Signal {get;}

        protected ProcessService(IEventSink sink)
        {
            Sink = sink;
            Host = GetType();
            Signal = EventSignal.create(sink, Host);
        }

        protected ProcessingFileEvent Processing(FS.FilePath src)
        {
            return Signal.Processing(src);
        }

        protected ProcessedFileEvent Processed(ProcessingFileEvent e)
        {
            return Signal.Processed(e.SourcePath);
        }

        protected BabbleEvent<T> Babble<T>(T src)
        {
            return Signal.Babble(src);
        }

        protected StatusEvent<T> Status<T>(T src)
        {
            return Signal.Status(src);
        }

        protected ErrorEvent<T> Error<T>(T src)
        {
            return Signal.Error(src);
        }
    }
}