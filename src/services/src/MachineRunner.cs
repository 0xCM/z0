//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Msg;

    public class MachineRunner : AppService<MachineRunner>
    {
        public void Run(WorkflowOptions options)
        {
            var parts = Wf.ApiCatalog.PartIdentities;
            var partList = Seq.delimit(Chars.Comma, 0, Wf.ApiCatalog.PartIdentities);
            var partCount = parts.Length;
            var flow = Wf.Running(RunningMachine.Format(partCount, partList));
            var hex = Wf.ApiHex();
            var decoder = Wf.AsmDecoder();
            try
            {
                var blocks = hex.ReadBlocks().Storage;
                var partitioned = blocks.ToHostBlocks();

                if(options.EmitHexIndex)
                    Emitted(hex.EmitIndex(blocks));

                if(options.EmitHexPack)
                    Emitted(Wf.HexPacks().Emit(blocks));

                if(options.EmitAsmRows)
                    Emitted(Wf.AsmRowBuilder().EmitAsmRows(blocks));

                if(options.EmitCallData || options.EmitJmpData)
                {
                    var routines = decoder.Decode(blocks);

                    if(options.EmitJmpData)
                        Emitted(Wf.AsmJmpPipe().EmitRows(routines.View));

                    if(options.EmitCallData)
                        Emitted(Wf.AsmCallPipe().EmitRows(routines.View));
                }

                if(options.EmitResBytes)
                    Emitted(Wf.ResPackEmitter().Emit(blocks));

                if(options.EmitStatements || options.EmitAsmBitstrings)
                {
                    var pipe = Wf.AsmStatementPipe();
                    var statements = Emitted(pipe.EmitStatements(partitioned));
                    if(options.EmitAsmBitstrings)
                        Emitted(Wf.AsmBitstringEmitter().EmitBitstrings(statements.SelectMany(x => x.ApiStatements)));
                }

                var apidata = Wf.ApiCatalogs();

                if(options.CorrelateMembers)
                    apidata.Correlate();

                if(options.EmitApiClasses)
                    apidata.EmitApiClasses();

                if(options.EmitAsmCatalogs)
                {
                    var etl = Wf.StanfordCatalog();
                    Emitted(etl.ImportSource());
                    Emitted(etl.ExportImport());
                    Wf.XedCatalog().EmitCatalog();
                }

                if(options.EmitIntrinsicsInfo)
                    Emitted(Wf.IntrinsicsCatalog().Emit());

                if(options.EmitSymbolicLiterals)
                    Emitted(Wf.Symbolism().EmitLiterals());

                if(options.EmitApiBitMasks)
                    Emitted(Wf.ApiBitMasks().Emit());

                if(options.CollectApiDocs)
                    Wf.ApiComments().Collect();

                var assets = Wf.ApiAssets();

                if(options.EmitAssetIndex)
                    Emitted(assets.EmitAssetIndex());

                if(options.EmitAssetContent)
                    Emitted(assets.EmitAssetContent());

                if(options.ProcessCultFiles)
                    Wf.CultProcessor().Run();

                Wf.ImageMetaPipe().EmitMetadaSets(options);

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

        Index<T> Emitted<T>(Index<T> src)
        {

            return src;
        }
    }
}