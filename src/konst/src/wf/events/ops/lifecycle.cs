//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    partial struct WfEvents
    {
        /// <summary>
        /// Defines a <see cref='WfStepCreated'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op]
        public static WfStepCreated created(WfStepId id, CorrelationToken ct, FlairKind flair = Created)
            => new WfStepCreated(id, ct, flair);

        /// <summary>
        /// Defines a <see cref='WfStepCreated{T}'/> event
        /// </summary>
        /// <param name="id">The step identifier</param>
        /// <param name="ct">The correlation token</param>
        /// <param name="flair">The flair</param>
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepCreated<T> created<T>(WfStepId id, T content, CorrelationToken ct, FlairKind flair = Created)
            => new WfStepCreated<T>(id, content, ct, flair);

        [MethodImpl(Inline), Op]
        public static ToolCreated created(WfToolId tool, CorrelationToken ct, FlairKind flair = Created)
            => new ToolCreated(tool, ct, flair);


        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static ProcessedFile processed(WfStepId step, WfDataFlow<FS.FilePath> flow, uint size, CorrelationToken ct)
            => new ProcessedFile(step, flow, size, ct);


        [MethodImpl(Inline), Op]
        public static EmittedFile emitted(WfStepId step, FS.FilePath path, CorrelationToken ct)
            => new EmittedFile(step, path, ct);


        [MethodImpl(Inline), Op]
        public static WfStepRunning running(WfActor actor, WfStepId step, CorrelationToken ct)
            => new WfStepRunning(step, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRunning<T> running<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStepRunning<T>(step, content, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRunning<T> running<S,T>(S step, T content, CorrelationToken ct)
            where S : struct, IWfStep<S>
                => new WfStepRunning<T>(step.Id, content, ct);

        [MethodImpl(Inline)]
        public static WfStepRunning<WfDataFlow<S,T>> running<S,T>(WfStepId step, WfDataFlow<S,T> flow, CorrelationToken ct)
            => new WfStepRunning<WfDataFlow<S,T>>(step, flow, ct);


        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRan<T> ran<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStepRan<T>(step, content, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRan<T> ran<S,T>(S step, T content, CorrelationToken ct)
            where S : struct, IWfStep<S>
                => new WfStepRan<T>(step.Id, content, ct);
    }
}