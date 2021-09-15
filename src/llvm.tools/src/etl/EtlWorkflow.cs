//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using static core;
    using static WsAtoms;

    using F = llvm.AsmRecordField;

    public partial class EtlWorkflow : AppService<EtlWorkflow>
    {
        llvm.LlvmPaths LlvmPaths;

        Index<llvm.OpCodeSpec> _LlvmOpCodes;

        LlvmRecordSources Sources;

        LineMap<AsmId> AsmDefMap;

        Index<AsmRecordField> AsmDefFields;

        public EtlWorkflow()
        {
            Sources = new();
            _LlvmOpCodes = new();
            AsmDefMap = LineMap<AsmId>.Empty;
        }

        protected override void Initialized()
        {
            LlvmPaths = Wf.LlvmPaths();
        }

        public Outcome RunEtl(out EtlDatasets datasets)
        {
            var result = Outcome.Success;
            Sources = LoadRecordSources();
            result = EmitTables();
            _LlvmOpCodes = MC.opcodes();
            TableEmit(_LlvmOpCodes.View, OpCodeSpec.RenderWidths, LlvmPaths.OpCodeTable());
            ImportLists(LlvmDatasetNames.TblgenLists, llvm);
            GenStringTables();
            AsmDefMap = MapAsmDefLines();
            AsmDefFields = LoadAsmDefFields();
            datasets = new EtlDatasets();
            datasets.RecordSourceData = Sources;
            datasets.AsmDefFieldData = AsmDefFields;
            datasets.AsmDefMapData = AsmDefMap;
            datasets.OpCodeData = _LlvmOpCodes;

            return EmitFields(datasets);
        }

        Outcome EmitFields(in EtlDatasets src)
        {
            var fields = src.AsmDefFields;
            var count = fields.Length;
            var dst = Ws.Tables().Subdir("llvm") + FS.file("llvm.fields", FS.Csv);
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