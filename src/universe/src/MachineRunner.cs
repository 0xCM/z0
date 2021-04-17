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
                var blocks = Wf.ApiIndexBuilder().IndexApiBlocks();
                var partitioned = ApiHostBlocks.partition(blocks.Blocks);

                if(options.EmitHexIndex)
                    Emitted(Wf.ApiHex().EmitIndex(blocks.Blocks));

                if(options.EmitHexPack)
                    Emitted(Wf.ApiHex().EmitHexPack(blocks.Blocks));

                if(options.EmitAsmRows)
                    Emitted(Wf.AsmRowStore().EmitAsmRows(blocks.Blocks));

                if(options.EmitCallData || options.EmitJmpData)
                {
                    var routines = Wf.ApiDecoder().Decode(blocks).Routines;

                    if(options.EmitJmpData)
                        Emitted(Wf.AsmJmpPipe().EmitRows(routines));

                    if(options.EmitCallData)
                        Emitted(Wf.AsmCallPipe().EmitRows(routines));
                }

                if(options.EmitResBytes)
                    Emitted(Wf.ResBytesEmitter().Emit(blocks.Blocks));

                if(options.EmitStatements || options.EmitAsmBitstrings)
                {
                    var pipe = Wf.AsmStatementPipe();
                    var statements = Emitted(pipe.EmitStatements(partitioned));
                    if(options.EmitAsmBitstrings)
                        Emitted(pipe.EmitBitstrings(statements.SelectMany(x => x.Statements)));
                }
                if(options.CorrelateMembers)
                    Wf.ApiCatalogs().Correlate();

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
                    Emitted(Wf.Symbolism().Emit());

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


        Index<T> Emitted<T>(Index<T> src)
        {

            return src;
        }
    }
}