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
    using static ClrRecords;

    [WfHost(CommandName)]
    public sealed class EmitClrHandles : WfHost<EmitClrHandles,ClrAssembly>
    {
        public const string CommandName = nameof(EmitClrHandles);

        protected override void Execute(IWfShell wf, in ClrAssembly src)
        {
            using var step = new EmitClrHandlesStep(wf, this, src);
            step.Run();
        }

        public static void run(IWfShell wf)
        {
            wf.Db().Clear(HandleRecord.TableId);
            var components = wf.Api.Components;
            foreach(var component in components)
            {
                EmitClrHandles.create().Run(wf, component);
            }
        }
    }

    ref struct EmitClrHandlesStep
    {
        readonly IWfShell Wf;

        public readonly ClrAssembly Source;

        public readonly FS.FilePath Target;

        readonly WfHost Host;

        public Span<HandleRecord> Records;

        readonly ReadOnlySpan<byte> RenderWidths;

        [MethodImpl(Inline)]
        public EmitClrHandlesStep(IWfShell wf, WfHost host, ClrAssembly src)
        {
            Wf = wf;
            Host = host;
            Source = src;
            Target = Wf.Db().Table(HandleRecord.TableId, Source.Part);
            Records = default;
            RenderWidths = HandleRecord.RenderWidths;
        }

        public void Run()
        {
            var handles = ClrHandles.methods(Source);
            var count = handles.Length;
            if(count != 0)
            {
                Wf.Running(Host, Source.SimpleName);

                Records = alloc<HandleRecord>(count);
                project(handles, Records);
                var counter = 0u;
                var t = default(HandleRecord);
                var formatter = TableRows.formatter(RenderWidths,t);
                using var dst = Target.Writer();
                dst.WriteLine(formatter.FormatHeader());
                for(var i=0; i<count; i++)
                {
                    ref readonly var record = ref skip(Records,i);
                    var row = formatter.FormatRow(record);
                    dst.WriteLine(row);
                    counter++;
                }

                Wf.EmittedTable(Host, counter, Target, t);
            }
        }

        [MethodImpl(Inline)]
        static void project(ReadOnlySpan<ClrHandle> src, Span<HandleRecord> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var handle = ref skip(src,i);
                ref var record = ref seek(dst,i);
                record.Address = handle.Pointer.Address;
                record.Key = handle.Key;
                record.Kind = handle.Kind;
            }
        }

        public void Dispose()
        {
        }
    }

}