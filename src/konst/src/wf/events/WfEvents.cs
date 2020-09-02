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
    using static AB;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost, Events]
    public readonly partial struct WfEvents
    {
        [MethodImpl(Inline)]
        static WfEventId<E> id<E>(WfStepId step, CorrelationToken ct)
            where E : struct, IWfEvent<E>
                => new WfEventId<E>(step, ct);

        [MethodImpl(Inline)]
        static WfEventId<E> id<E>(WfFunc fx, CorrelationToken ct)
            where E : struct, IWfEvent<E>
                => new WfEventId<E>(fx, ct);

        [MethodImpl(Inline), Op]
        public static EmittedFile emitted(WfStepId step, FS.FilePath path, CorrelationToken ct)
            => new EmittedFile(step, path, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<T> error<T>(string actor, T content, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
                => new WfError<T>(actor, content, ct, source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfError<T> error<T>(WfStepId step, T content, CorrelationToken ct,
            [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
                => new WfError<T>(step, content, ct, source(caller,file,line));

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
        /// Defines a <see cref='WorkerCreated'/> event
        /// </summary>
        /// <param name="ct">The correlation token</param>
        /// <param name="name">The actor name</param>
        [MethodImpl(Inline), Op]
        public static WorkerCreated newWorker(CorrelationToken ct, [File] string name = null)
            => new WorkerCreated(Path.GetFileNameWithoutExtension(name), ct);

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
        /// Defines a <see cref='WfStepCreated{T}'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepCreated<T> created<T>(WfStepId id, T content, CorrelationToken ct, MessageFlair flair = Created)
            => new WfStepCreated<T>(id, content, ct, flair);

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

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRan<T> ran<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStepRan<T>(step, content, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRan<T> ran<S,T>(S step, T content, CorrelationToken ct)
            where S : struct, IWfStep<S>
                => new WfStepRan<T>(step.Id, content, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfWarn<T> warn<T>(WfStepId step, T body, CorrelationToken ct)
            => new WfWarn<T>(step, body, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfProcessingFile<T> processing<T>(string actor, T kind, FilePath src, CorrelationToken ct)
            => new WfProcessingFile<T>(actor, kind, src, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfProcessedFile<T> processed<T>(string actor, T kind, FilePath src, uint size, CorrelationToken ct)
            => new WfProcessedFile<T>(actor, kind, src, size, ct);

        [MethodImpl(Inline), Op]
        public static WfEventOrigin origin(in WfEventId id, string actor, in WfCaller call)
            => new WfEventOrigin(id,actor, call);

        [MethodImpl(Inline), Op]
        public static WfEventOrigin origin(in WfEventId id, PartId part, string actor,
            [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int? line = null)
                    => new WfEventOrigin(id,actor, AB.caller(part, caller,file,line));
    }
}