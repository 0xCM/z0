//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
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

        public static void run(IWfShell wf)
        {
            wf.Db().ClearTables<ClrEnumRecord>();
            var components = wf.Api.PartComponents;
            foreach(var component in components)
            {
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

        public ClrEnumRecord[] Records;

        static ReadOnlySpan<byte> RenderWidths => new byte[ClrEnumRecord.FieldCount]{16, 36, 16, 24, 16, 16, 24, 16};

        [MethodImpl(Inline)]
        public EmitEnumsStep(IWfShell wf, WfHost host, ClrAssembly src)
        {
            Wf = wf;
            Host = host;
            Source = src;
            Target = Wf.Db().Table(ClrEnumRecord.TableId, Source.Part);
            Records = default;
        }

        public void Dispose()
        {
        }

        public void Run()
        {
            Records = ClrEnums.records(Source);
            if(Records.Length != 0)
            {
                var t = default(ClrEnumRecord);
                var formatter = TableFormatter.row<ClrEnumRecord>(RenderWidths);
                var flow = Wf.EmittingTable<ClrEnumRecord>(Target);
                var counter = 0u;
                Execute(ref counter, formatter);
                Wf.EmittedTable(flow, counter);
            }
        }

        void Execute(ref uint counter, in RowFormatter<ClrEnumRecord> formatter)
        {
            var src = @readonly(Records);
            var t = default(ClrEnumRecord);
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