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
                var asm = Wf.AsmDataStore();

                if(options.CorrelateMembers)
                {
                    api.Correlate();
                }

                if(options.EmitAsmCatalogs)
                {
                    var etl = Wf.AsmCatalogEtl();
                    etl.ImportSource();
                    etl.ExportImport();
                }

                if(options.EmitIntrinsicsInfo)
                    Wf.IntelCpuIntrinsics().Emit();

                if(options.EmitLiteralCatalogs)
                {
                    Wf.FieldLiteralEmitter().Run();
                    api.EmitSymbolicLiterals();
                    Wf.ApiBitMasks().Emit();
                }

                if(options.CollectApiDocs)
                {
                    ApiComments.create(Wf).Collect();
                }

                if(options.EmitResourceData)
                {
                    var assets = Wf.ApiAssets();
                    assets.EmitAssetIndex();
                    assets.EmitAssetContent();
                }

                if(options.EmitApiMetadata)
                    Wf.CliCmd().Run(CliWfCmdKind.DumpApiMetadata);

                if(options.RunXed)
                {
                    using var xed = XedWf.create(Wf);
                    xed.Run();
                }

                if(options.EmitSectionHeaders)
                    images.EmitRuntimeHeaders();

                if(options.EmitMsilRecords)
                    images.EmitMsilRecords();

                if(options.EmitCliStrings)
                {
                    images.EmitUserStrings();
                    images.EmitSystemStrings();
                }

                if(options.EmitCliConstants)
                    images.EmitConstants();

                if(options.EmitCliBlobs)
                    images.EmitApiBlobs();

                if(options.EmitImageContent)
                    images.EmitApiImageContent();

                if(options.EmitAsmRows)
                    asm.EmitAsmRows();

                if(options.EmitAsmAnalysis)
                    asm.EmitAnalyses();

                if(options.EmitResBytes)
                    asm.EmitResBytes();

                if(options.EmitStatements)
                    Wf.ApiStatementPipe().EmitStatements();

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}