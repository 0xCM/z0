//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".index-hex")]
        Outcome IndexHex(CmdArgs args)
        {
            var archive = Wf.ApiPacks().Archive();
            // var blocks = Wf.ApiHex().ReadBlocks();
            // Wf.ApiHex().EmitIndex(blocks, archive.TablePath<ApiHexIndexRow>());
            return true;
        }
    }
}