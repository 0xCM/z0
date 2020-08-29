//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static Render;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost]
    public readonly struct WfEvents
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<T> error<T>(string actor, T body, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
                => new WfError<T>(actor, body, ct, AB.source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<T> error<T>(in WfActor actor, T body, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
                => new WfError<T>(actor, body, ct, AB.source(caller,file,line));

        [Op]
        public static WfError<string> error(Exception e, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
        {
            const string CallerPattern = "An error was trapped by {0} on line {1} in {2}";
            const string Pattern = "{0}" + Eol + "{1}";
            var where = text.format(CallerPattern, caller, line, file);
            var what = e.ToString();
            var msg = text.format(Pattern, where, what);
            return error(caller, msg, ct);
        }

        /// <summary>
        /// Defines an actor with a specified name, if given; otherwise the actor name is derived
        /// from the path of the invoking member file
        /// </summary>
        /// <param name="name">The actor name</param>
        [MethodImpl(Inline), Op]
        public static WfWorker worker([CallerFilePath] string name = null)
            => new WfWorker(Path.GetFileNameWithoutExtension(name));

        /// <summary>
        /// Defines a <see cref='WorkerCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="name">The actor name</param>
        [MethodImpl(Inline), Op]
        public static WorkerCreated newWorker(CorrelationToken ct, [File] string name = null)
            => new WorkerCreated(worker(name), ct);

        /// <summary>
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static WfStepCreated created(WfStepId id, CorrelationToken ct, MessageFlair flair = Created)
            => new WfStepCreated(id, ct, flair);

        /// <summary>
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static WfStepCreated created(in WfActor actor, WfStepId id, CorrelationToken ct, MessageFlair flair = Created)
            => new WfStepCreated(actor, id, ct, flair);

        /// <summary>
        /// Defines a <see cref='WorkerCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="worker">The actor</param>
        [MethodImpl(Inline), Op]
        public static WorkerCreated created(CorrelationToken ct, in WfWorker worker)
            => new WorkerCreated(worker, ct);

        /// <summary>
        /// Defines a <see cref='WfActorCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="actor">The actor</param>
        [MethodImpl(Inline), Op]
        public static WfActorCreated created(CorrelationToken ct, in WfActor actor)
            => new WfActorCreated(actor, ct);

        /// <summary>
        /// Creates a <see cref='WfStatus{T}'/> message
        /// </summary>
        /// <param name="step">The executing step</param>
        /// <param name="content">The status content</param>
        /// <param name="ct">The correlation token</param>
        /// <typeparam name="T">The content type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStatus<T> status<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStatus<T>(step, content, ct);

        [MethodImpl(Inline), Op]
        public static WfStepRunning running(WfActor actor, WfStepId step, CorrelationToken ct)
            => new WfStepRunning(actor, step, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRunning<T> running<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStepRunning<T>(step, content, ct);

        [MethodImpl(Inline)]
        public static WfStepRunning<WfDataFlow<S,T>> running<S,T>(WfStepId step, WfDataFlow<S,T> flow, CorrelationToken ct)
            => new WfStepRunning<WfDataFlow<S,T>>(step, flow, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRan<T> ran<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStepRan<T>(step, content, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfWarn<T> warn<T>(WfStepId step, T body, CorrelationToken ct)
            => new WfWarn<T>(step, body, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfProcessingFile<T> processing<T>(string actor, T kind, FilePath src, CorrelationToken ct)
            => new WfProcessingFile<T>(actor, kind, src, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfProcessedFile<T> processed<T>(string actor, T kind, FilePath src, uint size, CorrelationToken ct)
            => new WfProcessedFile<T>(actor, kind, src, size, ct);
    }
}