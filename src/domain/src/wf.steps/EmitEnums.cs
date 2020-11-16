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
    using static CliRecords;

    [WfHost(CommandName)]
    public sealed class EmitEnums : WfHost<EmitEnums,ClrAssembly>
    {
        public const string CommandName = nameof(EmitEnums);

        protected override void Execute(IWfShell wf, in ClrAssembly src)
        {
            using var step = new EmitEnumsStep(wf, this, src);
            step.Run();
        }

        const char XX = '\uDECC';

        public static void run(IWfShell wf)
        {
            wf.Db().Clear(EnumLiteralRecord.TableId);
            var components = wf.Api.Components;
            foreach(var component in components)
            {
                if(component.Id() != PartId.AsmModels)
                    EmitEnums.create().Run(wf, component);
            }
        }
    }

    ref struct EmitEnumsStep
    {
        readonly IWfShell Wf;

        public readonly ClrAssembly Source;

        public readonly FS.FilePath Target;

        readonly WfHost Host;

        public EnumLiteralRecord[] Records;

        readonly ReadOnlySpan<byte> RenderWidths;

        [MethodImpl(Inline)]
        public EmitEnumsStep(IWfShell wf, WfHost host, ClrAssembly src)
        {
            Wf = wf;
            Host = host;
            Source = src;
            Target = Wf.Db().Table(EnumLiteralRecord.TableId, Source.Part);
            Records = default;
            RenderWidths = EnumLiteralRecord.RenderWidths;
        }

        public void Dispose()
        {
        }

        public void Run()
        {
            Records = ClrEnums.literals(Source);
            if(Records.Length != 0)
            {
                var t = default(EnumLiteralRecord);
                var formatter = TableFormatter.row(RenderWidths,t);
                Wf.Running(Host, Source.SimpleName);
                var counter = 0u;
                Execute(ref counter, formatter);
                Wf.EmittedTable(Host, counter, Target, t);
            }
        }

        void Execute(ref uint counter, in RowFormatter<EnumLiteralRecord> formatter)
        {
            var src = @readonly(Records);
            var t = default(EnumLiteralRecord);
            var count = src.Length;
            using var dst = Target.Writer();
            dst.WriteLine(formatter.FormatHeader());

            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref skip(src,i);
                try
                {
                    var row = formatter.FormatRow(record);
                    dst.WriteLine(row);
                    counter++;
                }
                catch(Exception)
                {
                    var msg = $"Error emitting row {i}/{count}";
                    dst.WriteLine(msg);
                    Wf.Warn(Host, msg);
                }
            }
        }
    }
}