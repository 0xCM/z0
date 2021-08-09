//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public abstract class Service<H> : IService
        where H : Service<H>, new()
    {
        /// <summary>
        /// Instantites the serice without initialization
        /// </summary>
        [MethodImpl(Inline)]
        protected static H @new() => new H();

        public EnvData Env {get; protected set;}

        /// <summary>
        /// Creates and initializes the service
        /// </summary>
        /// <param name="wf">The source workflow</param>
        public static H create(IServiceContext ctx)
        {
            var service = @new();
            service.Init(ctx);
            return service;
        }

        protected EnvPaths Paths {get; private set;}

        protected IServiceContext Context {get; private set;}

        EventSignal Signal;

        public void Init(IServiceContext ctx)
        {
            Context = ctx;
            Env = ctx.Env;
            Paths = new EnvPaths(Env);
            Signal = EventSignals.signal(ctx.EventSink, typeof(H));
            Initialized();
        }

        protected virtual void Initialized() {}


        protected DataEvent<T> Row<T>(T src)
        {
            return Signal.Data(src);
        }


        protected BabbleEvent<T> Babble<T>(T src)
        {
            return Signal.Babble(src);
        }

        protected StatusEvent<T> Status<T>(T src)
        {
            return Signal.Status(src);
        }

        protected WarnEvent<T> Warn<T>(T src)
        {
            return Signal.Warn(src);
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

        protected EmittedFileEvent Emitted(EmittingFileEvent e, Count metric)
        {
            return Signal.EmittedFile(metric, e.Target);
        }
    }
}