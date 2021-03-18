//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public class MachineRunner : WfService<MachineRunner>
    {
        public void Run(MachineOptions options)
        {
            using var flow = Wf.Running();
            Wf.Status(Seq.delimit(Wf.Api.PartIdentities));
            try
            {
                var api = Wf.ApiServices();
                var images = Wf.ImageDataEmitter();
                var asm = Wf.AsmDataStore();

                api.Correlate();

                if(options.EmitAsmCatalogs)
                {
                    var etl = Wf.AsmCatalogEtl();
                    etl.ImportSource();
                    etl.ExportImport();
                }

                if(options.EmitIntrinsicsInfo)
                    IntelIntrinsics.create(Wf).Emit();

                if(options.EmitLiteralCatalogs)
                {
                    Wf.FieldLiteralEmitter().Run();
                    api.EmitSymbolicLiterals();
                    Wf.ApiBitMasks().Emit();
                }

                if(options.CollectApiDocs)
                {
                    EmitComments.create().Run(Wf);
                }

                if(options.EmitResourceData)
                {
                    var assets = Wf.ApiAssets();
                    assets.EmitAssetIndex();
                    assets.EmitAssetContent();
                }

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
                    root.iter(Wf.Api.PartComponents, c => images.EmitImageContent(c));

                if(options.EmitAsmRows)
                    asm.EmitAsmRows();

                if(options.EmitAsmAnalysis)
                    asm.EmitAnalyses();

                if(options.EmitResBytes)
                    asm.EmitResBytes();

                if(options.EmitStatements)
                    asm.EmitApiStatements();

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}