//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".machine")]
        Outcome RunMachine(CmdArgs args)
        {
            var result = Outcome.Success;
            var proj = "z0";
            var subject = "statements";
            var outdir = Projects().Out(proj) + FS.folder(subject);
            var apihex = Wf.ApiHex();
            var emitter = Wf.AsmStatementPipe();
            var loader = Wf.AsmDataPipes();

            var blocks = apihex.ReadBlocks().View;
            var count = blocks.Length;
            for(var i=0; i<20; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                var uri = block.OpUri;
                var code = block.Encoded;
                var array = HexArray.load(code);
                var fmt = string.Format("{0}:{1}", uri, array);
                Write(fmt);
            }

            // emitter.EmitHostStatements(blocks, outdir);
            // var parsed = loader.LoadHostStatements(outdir);

            return result;
        }

        Outcome RunMachine2(CmdArgs args)
        {
            var options = WorkflowOptions.@default();
            options.EmitXedCatalogs = false;
            options.CorrelateMembers = false;
            options.EmitIntrinsicsInfo = false;
            options.CollectApiDocs = false;
            options.ProcessCultFiles = false;
            options.EmitAssetIndex = false;
            options.EmitImageContent = false;
            options.EmitCliBlobs = false;
            options.EmitCliConstants = false;
            options.EmitCliStrings = false;
            options.EmitAssemblyRefs = true;
            options.EmitApiMetadump = false;

            var blocks = Wf.ApiHex().ReadBlocks();
            var partitioned = CodeBlocks.hosted(blocks.View);
            var sorted = blocks.Sorted();
            var archive = Wf.ApiPacks().Archive();

            if(options.EmitHexIndex)
                Wf.ApiHex().EmitIndex(blocks, archive.TablePath<ApiHexIndexRow>());

            if(options.EmitHexPack)
                Wf.ApiHexPacks().Emit(sorted, archive.TablePath<HexPacked>());

            if(options.EmitResBytes)
                Wf.ResPackEmitter().Emit(blocks.View, archive.CodeGenDir("respack"));

            var catalogs = Wf.ApiCatalogs();

            if(options.CorrelateMembers)
                catalogs.Correlate();

            if(options.EmitApiClasses)
                catalogs.EmitApiClasses(archive.TablePath("apiclasses"));

            if(options.EmitXedCatalogs)
                Wf.IntelXed().EmitCatalog();

            if(options.EmitIntrinsicsInfo)
                Wf.IntelIntrinsics().Emit();

            if(options.EmitSymbolicLiterals)
                Wf.Symbolism().EmitLiterals(archive.TablePath("symlits"));

            if(options.EmitApiBitMasks)
                Wf.ApiBitMasks().Emit(archive.TablePath<BitMaskInfo>());

            if(options.CollectApiDocs)
                Wf.ApiComments().Collect();

            if(options.EmitAssetIndex)
                Wf.ApiAssets().EmitAssetIndex();

            if(options.EmitAssetContent)
                Wf.ApiAssets().EmitAssetContent();

            if(options.ProcessCultFiles)
                Wf.CultProcessor().Process();

            var cli = Wf.CliEmitter();
            if(options.EmitAssemblyRefs)
                cli.EmitAssemblyRefs(Wf.Components, archive.TablePath<AssemblyRefInfo>());

            if(options.EmitFieldMetadata)
                cli.EmitFieldMetadata();

            if(options.EmitApiMetadump)
                cli.EmitApiMetadump(archive.Dumps("cli.metadata"));

            if(options.EmitSectionHeaders)
                cli.EmitSectionHeaders(archive.TableDir());

            if(options.EmitMsilMetadata)
                cli.EmitMsilMetadata();

            if(options.EmitCliStrings)
            {
                cli.EmitUserStrings();
                cli.EmitSystemStringInfo();
            }

            if(options.EmitCliConstants)
                cli.EmitConstants(archive.TableDir());

            if(options.EmitCliBlobs)
                cli.EmitBlobs();

            if(options.EmitImageContent)
                cli.EmitImageContent();

            return true;
        }
    }
}