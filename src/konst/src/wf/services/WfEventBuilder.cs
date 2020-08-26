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
    public readonly struct WfEventBuilder
    {
        [Op, Closures(UnsignedInts)]
        public static WfError<T> error<T>(string actor, T body, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => new WfError<T>(actor, body, ct, AppMsgSource.create(caller,file,line));

        [Op]
        public static WfError<string> error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
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

        [MethodImpl(Inline), Op]
        public static WfStepRunning running(WfActor actor, WfStepId step, CorrelationToken ct)
            => new WfStepRunning(actor, step, ct);

        [MethodImpl(Inline), Op]
        public static WfStepRunning ran(in WfActor actor, in WfStepId step, CorrelationToken ct)
            => new WfStepRunning(actor, step, ct);

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
    }
}