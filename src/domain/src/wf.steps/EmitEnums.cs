//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

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
            wf.Db().Clear(ClrEnumLiteralRecord.TableId);
            var components = wf.Api.PartComponents;
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

        public ClrEnumLiteralRecord[] Records;

        static ReadOnlySpan<byte> RenderWidths => new byte[ClrEnumLiteralRecord.FieldCount]{16, 36, 16, 24, 16, 16, 24, 16};

        [MethodImpl(Inline)]
        public EmitEnumsStep(IWfShell wf, WfHost host, ClrAssembly src)
        {
            Wf = wf;
            Host = host;
            Source = src;
            Target = Wf.Db().Table(ClrEnumLiteralRecord.TableId, Source.Part);
            Records = default;
        }

        public void Dispose()
        {
        }

        public void Run()
        {
            Records = ClrEnums.literals(Source);
            if(Records.Length != 0)
            {
                var t = default(ClrEnumLiteralRecord);
                var formatter = TableFormatter.row<ClrEnumLiteralRecord>(RenderWidths);
                var flow = Wf.EmittingTable<ClrEnumLiteralRecord>(Target);
                var counter = 0u;
                Execute(ref counter, formatter);
                Wf.EmittedTable<ClrEnumLiteralRecord>(Host, counter, Target);
            }
        }

        void Execute(ref uint counter, in RowFormatter<ClrEnumLiteralRecord> formatter)
        {
            var src = @readonly(Records);
            var t = default(ClrEnumLiteralRecord);
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