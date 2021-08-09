//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".load-hex-packs")]
        Outcome LoadHexPacks(CmdArgs args)
        {
            var result = Outcome.Success;
            var pack = ApiPacks.List().Last;
            var packs = HexPacks.LoadParsed(pack.HexPackRoot());
            return result;
        }
    }
}