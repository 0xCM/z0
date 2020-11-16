//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [WfHost(CommandName)]
    public sealed class EmitClrHandles : WfHost<EmitClrHandles,ClrAssembly>
    {
        public const string CommandName = nameof(EmitClrHandles);

        protected override void Execute(IWfShell wf, in ClrAssembly src)
        {
            using var step = new EmitClrHandlesStep(wf, this, src);
            step.Run();
        }

        [CmdWorker]
        public static CmdResult run(IWfShell wf, EmitClrHandlesCmd cmd)
        {
            wf.Db().Clear(ClrHandleRecord.TableId);
            var components = wf.Api.Components;
            foreach(var component in components)
            {
                EmitClrHandles.create().Run(wf, component);
            }
            return new CmdResult(cmd, true);
        }
    }

    ref struct EmitClrHandlesStep
    {
        readonly IWfShell Wf;

        public readonly ClrAssembly Source;

        readonly WfHost Host;

        public Span<ClrHandleRecord> Emitted;

        [MethodImpl(Inline)]
        public EmitClrHandlesStep(IWfShell wf, WfHost host, ClrAssembly src)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Source = src;
            Emitted = default;
        }

        public void Run()
        {
            // var handles = ClrHandles.methods(Source);
            // var count = (uint)handles.Length;
            // var target = Wf.Db().Table(HandleRecord.TableId, Source.Part);
            // if(count != 0)
            // {
            //     Wf.EmittingTable<HandleRecord>(target);

            //     Emitted = alloc<HandleRecord>(count);
            //     ClrRecords.project(handles, Emitted);
            //     var counter = 0u;
            //     var t = default(HandleRecord);
            //     var formatter = TableRows.formatter(HandleRecord.RenderWidths,t);
            //     using var dst = target.Writer();
            //     dst.WriteLine(formatter.FormatHeader());
            //     count += ClrRecords.project(Emitted, dst);

            //     Wf.EmittedTable<HandleRecord>(Host, counter, target);
            // }
        }

        public void Dispose()
        {
        }
    }

}