//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    /// <summary>
    /// Characterizes a worklow context
    /// </summary>
    public interface IWfContext : IWfShell
    {
        IAppContext ContextRoot {get;}

        IWfBroker Broker {get;}

        IShellContext IWfShell.Shell
            => ContextRoot;

        FilePath ResPack
            => FilePath.Define(@"J:\dev\projects\z0-logs\respack\.bin\lib\netcoreapp3.0\z0.respack.dll");

        void Error(WfStepId step, Exception e)
            => Raise(WfEvents.error(step, e, Ct));

        void Error<T>(WfStepId step,T content)
            => Raise(WfEvents.error(step, content,  Ct));

        void Error(in WfActor actor, Exception e, CorrelationToken? ct = null)
            => Raise(WfEvents.error(WfStepId.Empty, e, ct ?? Ct));

        void Warn<T>(WfStepId step, T content)
            => Raise(WfEvents.warn(step, content, Ct));

        void Processing<T>(T kind, FilePath src, [File] string actor = null, [Line] int? line = null)
            => Raise(WfEvents.processing(Path.GetFileNameWithoutExtension(actor), kind, src, Ct));

        void Processed<T>(T kind, FilePath src, uint size, [File] string actor = null, [Line] int? line = null)
            => Raise(WfEvents.processed(ToActorName(actor), kind, src, size, Ct));

        void Ran(string actor, CorrelationToken ct)
            => Flow.ran(this, actor, "Finished", ct);

        void Ran<T>(string actor, T content, CorrelationToken? ct = null)
            => Raise(WfEvents.ran(WfStepId.Empty, content, ct ?? Ct));

        void Status<T>(WfStepId worker, T message, CorrelationToken ct)
            => Flow.status(this, worker, message,ct);

        void RunningT<T>(string actor, T output, CorrelationToken? ct = null)
            => Raise(WfEvents.running(WfStepId.Empty, output, Ct));

        void RanT<T>(string actor, T output, CorrelationToken? ct = null)
            => Flow.ran(this, actor, output, ct ?? Ct);

        static string ToActorName(string src)
            => Path.GetFileNameWithoutExtension(src);
    }
}