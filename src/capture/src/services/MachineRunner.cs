//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Msg;
    using static core;

    public class MachineRunner : AppService<MachineRunner>
    {
        public void Run(WorkflowOptions options)
        {
            var parts = Wf.ApiCatalog.PartIdentities;
            var partList = Seq.delimit(Chars.Comma, 0, parts);
            var partCount = parts.Length;
            var flow = Wf.Running(RunningMachine.Format(partCount, partList));
            var hex = Wf.ApiHex();
            var decoder = Wf.AsmDecoder();
            try
            {
                var blocks = hex.ReadBlocks().Storage;
                var partitioned = CodeBlocks.hosted(@readonly(blocks));
                var sorted = blocks.ToSortedSpan();

                if(options.EmitHexIndex)
                    hex.EmitIndex(blocks);

                if(options.DryRun)
                {
                    Wf.Ran(flow);
                    return;
                }

                if(options.EmitHexPack)
                    Wf.ApiHexPacks().Emit(sorted);

                if(options.EmitAsmRows)
                    Wf.AsmRowBuilder().Emit(blocks);

                if(options.EmitCallData)
                {
                    var routines = decoder.Decode(@readonly(blocks));
                    if(options.EmitCallData)
                        Wf.AsmCallPipe().EmitRows(routines);
                }

                if(options.EmitResBytes)
                    Wf.ResPackEmitter().Emit(blocks);

                if(options.EmitStatements)
                {
                    var pipe = Wf.AsmStatementPipe();
                    pipe.EmitHostStatements(partitioned, Db.AsmStatementRoot());
                }

                var apidata = Wf.ApiCatalogs();

                if(options.CorrelateMembers)
                    apidata.Correlate();

                if(options.EmitApiClasses)
                    apidata.EmitApiClasses();

                if(options.EmitAsmCatalogs)
                {
                    var etl = Wf.StanfordCatalog();
                    etl.ExportAsset();
                    etl.ImportExported();
                    Wf.IntelXed().EmitCatalog();
                }

                if(options.EmitIntrinsicsInfo)
                    Wf.IntelIntrinsicsPipe().Import();

                if(options.EmitSymbolicLiterals)
                    Wf.Symbolism().EmitLiterals();

                if(options.EmitApiBitMasks)
                    Wf.ApiBitMasks().Emit();

                if(options.CollectApiDocs)
                    Wf.ApiComments().Collect();

                var assets = Wf.ApiAssets();

                if(options.EmitAssetIndex)
                    assets.EmitAssetIndex();

                if(options.EmitAssetContent)
                    assets.EmitAssetContent();

                if(options.ProcessCultFiles)
                    Wf.CultProcessor().Run();

                Wf.CliEmitter().EmitMetadaSets(options);

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran(flow, RanMachine.Format(partCount, partList));
        }
    }
}