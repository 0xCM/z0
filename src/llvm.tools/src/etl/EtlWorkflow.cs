//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static WsAtoms;
    using static Root;

    public class EtlDatasets
    {
        internal Index<AsmRecordField> AsmDefFieldData;

        internal Index<llvm.OpCodeSpec> OpCodeData;

        internal LineMap<AsmId> AsmDefMapData;

        internal LlvmRecordSources RecordSourceData;

        public LineMap<AsmId> AsmDefMap
        {
            [MethodImpl(Inline)]
            get => AsmDefMapData;
        }

        public LlvmRecordSources RecordSources
        {
            [MethodImpl(Inline)]
            get => RecordSourceData;
        }

        public ReadOnlySpan<AsmRecordField> AsmDefFields
        {
            [MethodImpl(Inline)]
            get => AsmDefFieldData.View;
        }

        public ReadOnlySpan<OpCodeSpec> OpCodes
        {
            [MethodImpl(Inline)]
            get => OpCodeData.View;
        }
    }

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
            return result;
        }

         void Emit(TableGenRecord src, FS.FilePath dst)
         {
            using var writer = dst.AsciWriter();
            foreach(var line in src.Lines)
            {
                writer.WriteLine(line.Content);
                Write(line);
            }

            if(src.Fields.Count != 0)
                iter(src.Fields, f => Write(f));
         }
   }
}