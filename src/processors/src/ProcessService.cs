//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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

        protected ProcessingFileEvent Processing(FS.FilePath src)
        {
            return Signal.Processing(src);
        }

        protected RunningEvent Running()
        {
            return Signal.Running();
        }

        protected RunningEvent<T> Running<T>(T data)
        {
            return Signal.Running(data);
        }

        protected RanEvent<T> Ran<T>(RunningEvent<T> e, T data)
        {
            return Signal.Ran(data);
        }

        protected ProcessedFileEvent Processed(ProcessingFileEvent e)
        {
            return Signal.Processed(e.SourcePath);
        }

        protected EmittingFileEvent Emitting(FS.FilePath src)
        {
            return Signal.EmittingFile(src);
        }

        protected EmittedFileEvent Emitted(FS.FilePath src)
        {
            return Signal.EmittedFile(src);
        }

        protected EmittedFileEvent Emitted(EmittingFileEvent e, Count metric)
        {
            return Signal.EmittedFile(metric, e.Target);
        }

        protected EmittedFileEvent Emitted(Count metric, FS.FilePath src)
        {
            return Signal.EmittedFile(metric, src);
        }
    }
}