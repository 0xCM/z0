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

        static MsgPattern<Count, DelimitedIndex<PartId>> RanMachine => "Executed machine workflow for {0} parts: {1}";

        public void Run(MachineOptions options)
        {
            var parts = Wf.Api.PartIdentities;
            var partList = Seq.delimit(Chars.Comma, 0, Wf.Api.PartIdentities);
            var partCount = parts.Length;
            var flow = Wf.Running(RunningMachine.Format(partCount, partList));
            try
            {
                var blocks = Wf.ApiCodeStore().IndexedBlocks();

                if(options.EmitHexIndex)
                    Emitted(Wf.ApiHex().EmitHexIndex(blocks));

                if(options.EmitAsmRows)
                    Emitted(Wf.AsmRowStore().EmitAsmRows(blocks));

                if(options.EmitCallData || options.EmitJmpData)
                {
                    var decoded = Wf.ApiDecoder().Decode(blocks);

                    if(options.EmitJmpData)
                        Emitted(Wf.AsmJmpPipe().EmitRows(decoded));

                    if(options.EmitCallData)
                        Emitted(Wf.AsmCallPipe().EmitRows(decoded));
                }

                if(options.EmitResBytes)
                    Emitted(Wf.ResBytesEmitter().Emit(blocks));

                var statements = Wf.AsmStatementPipe();
                if(options.EmitStatements)
                    Emitted(statements.EmitStatements(blocks));

                if(options.EmitAsmBitstrings)
                    Emitted(statements.EmitBitstrings());

                if(options.CorrelateMembers)
                    Wf.ApiServices().Correlate();

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

                var assets = Wf.ApiAssets();

                if(options.EmitAssetIndex)
                    Emitted(assets.EmitAssetIndex());

                if(options.EmitAssetContent)
                    Emitted(assets.EmitAssetContent());

                if(options.EmitApiMetadata)
                    Wf.CliTables().DumpApiMetadata();

                var images = Wf.ImageDataEmitter();

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

            Wf.Ran(flow, RanMachine.Format(partCount, partList));
        }

        void Emitted<T>(ReadOnlySpan<T> src)
        {

        }


        void Emitted<T>(Index<T> src)
            => Emitted(src.View);
    }
}