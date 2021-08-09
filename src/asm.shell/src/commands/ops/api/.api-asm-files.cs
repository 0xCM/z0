//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".api-asm-files")]
        Outcome ApiAsmFiles(CmdArgs args)
        {
            var result = Outcome.Success;
            var pairs = ApiArchive.StatementTablePairs().View;
            var count = pairs.Length;
            for(var i=0; i<count; i++)
            {
                (var csv, var asm) = skip(pairs,i);
                Write(string.Format("{0} | {1}", csv.ToUri(), asm.ToUri()));

            }

            return result;
        }

        FS.Files ApiAsmPaths(PartId part)
            => Files(ApiPack.AsmCapturePaths(part));

    }
}