//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;

    using F = llvm.AsmRecordField;

    public partial class EtlWorkflow : AppService<EtlWorkflow>
    {
        Index<OpCodeSpec> _LlvmOpCodes;

        LlvmRecordSources Sources;

        IProjectWs LlvmData;

        public EtlWorkflow()
        {
            Sources = new();
            _LlvmOpCodes = new();
        }

        protected override void Initialized()
        {
            LlvmData = Ws.Project("llvm.data");
        }

        public Outcome RunEtl()
        {
            var records = LoadRecords();
            var result = Outcome.Success;
            // Sources = LoadRecordSources();
            EmitTables(records);
            _LlvmOpCodes = MC.opcodes();
            TableEmit(_LlvmOpCodes.View, OpCodeSpec.RenderWidths, LlvmData.TablePath<OpCodeSpec>());
            // ImportLists();
            // GenStringTables();
            var map = MapDefinitions(records);
            var fields = LoadFields(records, map);
            var datasets = new EtlDatasets();
            datasets.AsmDefFieldData = fields;
            datasets.AsmDefMapData = map;
            datasets.OpCodeData = _LlvmOpCodes;
            return EmitFields(datasets);
        }

        public static ReadOnlySpan<AsmRecordFields> partition(ReadOnlySpan<AsmRecordField> src)
        {
            var count = src.Length;
            var dst = list<AsmRecordFields>();
            var subset = list<AsmRecordField>();
            var current = AsmId.PHI;
            for(var i=0; i<count; i++)
            {
                ref readonly var f = ref skip(src,i);
                ref readonly var id = ref f.Id;
                if(id != current)
                {
                    if(subset.Count != 0)
                    {
                        dst.Add(new AsmRecordFields(current, subset.ToArray()));
                        subset.Clear();
                        current = id;
                    }
                    subset.Add(f);
                }

            }
            if(subset.Count != 0)
                dst.Add(new AsmRecordFields(current, subset.ToArray()));
            return dst.ViewDeposited();
        }

        Outcome EmitFields(in EtlDatasets src)
        {
            var fields = src.AsmDefFields;
            var count = fields.Length;
            var dst = LlvmData.Tables() + FS.file("llvm.fields", FS.Csv);
            var emitting = EmittingTable<F>(dst);
            using var writer = dst.AsciWriter();
            writer.WriteLine(F.RowHeader);
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                writer.WriteLine(string.Format(F.RowFormat, field.Id, field.Type, field.Name, field.Value));
            }

            EmittedTable(emitting, count);
            return true;
        }
   }
}