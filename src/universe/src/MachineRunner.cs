//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class MachineRunner : WfService<MachineRunner>
    {
        public void Run(MachineOptions options)
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.delimit(Chars.Comma, 0, Wf.Api.PartIdentities));
            try
            {
                var api = Wf.ApiServices();
                var images = Wf.ImageDataEmitter();
                var store = Wf.AsmDataStore();
                var assets = Wf.ApiAssets();
                var blocks = store.CodeBlocks();
                var asmrows = Wf.AsmRowStore().EmitAsmRows(blocks);

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
                    Emitted(api.EmitSymbolicLiterals());

                if(options.EmitApiBitMasks)
                    Emitted(Wf.ApiBitMasks().Emit());

                if(options.EmitFieldLiterals)
                    Wf.FieldLiteralEmitter().Run();

                if(options.CollectApiDocs)
                    Wf.ApiComments().Collect();

                if(options.EmitAssetIndex)
                    assets.EmitAssetIndex();

                if(options.EmitAssetContent)
                    Emitted(assets.EmitAssetContent());

                if(options.EmitApiMetadata)
                    Wf.CliCmd().Run(CliWfCmdKind.DumpApiMetadata);

                if(options.EmitSectionHeaders)
                    images.EmitRuntimeHeaders();

                if(options.EmitMsilRecords)
                    images.EmitMsilRecords();

                if(options.EmitCliStrings)
                {
                    images.EmitUserStrings();
                    Emitted(images.EmitSystemStrings());
                }

                if(options.EmitCliConstants)
                    images.EmitConstants();

                if(options.EmitCliBlobs)
                    images.EmitApiBlobs();

                if(options.EmitImageContent)
                    images.EmitApiImageContent();

                if(options.EmitAsmAnalysis)
                    store.EmitAnalyses(blocks);

                if(options.EmitResBytes)
                    store.EmitResBytes(blocks);

                if(options.EmitStatements)
                    Wf.AsmStatementPipe().EmitStatements();

                if(options.EmitAsmBitstrings)
                    Wf.AsmStatementPipe().EmitBitstrings();

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