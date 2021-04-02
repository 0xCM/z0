//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class MachineRunner : WfService<MachineRunner>
    {
        static MsgPattern<Count, DelimitedIndex<PartId>> RunningMachine => "Executing machine workflow for {0} parts: {1}";

        public void Run(MachineOptions options)
        {
            var parts = Wf.Api.PartIdentities;
            using var flow = Wf.Running(RunningMachine.Format(parts.Length, Seq.delimit(Chars.Comma, 0, Wf.Api.PartIdentities)));
            try
            {
                var api = Wf.ApiServices();
                var images = Wf.ImageDataEmitter();
                var store = Wf.ApiCodeStore();
                var assets = Wf.ApiAssets();
                var rowstore = Wf.AsmRowStore();
                var statements = Wf.AsmStatementPipe();

                var blocks = store.CodeBlocks();

                if(options.EmitHexIndex)
                    Wf.ApiHex().EmitHexIndex(blocks);

                if(options.EmitAsmRows)
                    Emitted(rowstore.EmitAsmRows(blocks));

                if(options.EmitAsmAnalysis)
                    rowstore.EmitAnalyses(blocks);

                if(options.EmitResBytes)
                    Emitted(Wf.ResBytesEmitter().Emit(blocks));

                if(options.EmitStatements)
                    Emitted(statements.EmitStatements(blocks));

                if(options.EmitAsmBitstrings)
                    statements.EmitBitstrings();

                if(options.CorrelateMembers)
                    api.Correlate();

                if(options.EmitAsmCatalogs)
                {
                    var etl = Wf.AsmCatalogEtl();
                    Emitted(etl.ImportSource());
                    Emitted(etl.ExportImport());

                    var xed = Wf.Xed();
                    xed.EmitForms();
                    xed.EmitClasses();
                    xed.EmitSumbolSummary();
                }

                if(options.EmitIntrinsicsInfo)
                    Emitted(Wf.IntelCpuIntrinsics().Emit());

                if(options.EmitSymbolicLiterals)
                    Emitted(Wf.SymLiterals().Emit());

                if(options.EmitApiBitMasks)
                    Emitted(Wf.ApiBitMasks().Emit());

                if(options.EmitFieldLiterals)
                    Wf.FieldLiteralEmitter().Run();

                if(options.CollectApiDocs)
                    Wf.ApiComments().Collect();

                if(options.EmitAssetIndex)
                    Emitted(assets.EmitAssetIndex());

                if(options.EmitAssetContent)
                    Emitted(assets.EmitAssetContent());

                if(options.EmitApiMetadata)
                    Wf.CliTables().DumpApiMetadata();

                if(options.EmitSectionHeaders)
                    images.EmitRuntimeHeaders();

                if(options.EmitMsilRecords)
                    images.EmitMsilRecords();

                if(options.EmitCliStrings)
                {
                    Emitted(images.EmitUserStrings());
                    Emitted(images.EmitSystemStrings());
                }

                if(options.EmitCliConstants)
                    images.EmitConstants();

                if(options.EmitCliBlobs)
                    images.EmitApiBlobs();

                if(options.EmitImageContent)
                    images.EmitApiImageContent();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        void Emitted<T>(ReadOnlySpan<T> src)
        {

        }


        void Emitted<T>(Index<T> src)
            => Emitted(src.View);
    }
}