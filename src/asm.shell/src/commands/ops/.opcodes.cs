//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".opcodes")]
        public Outcome OpCodes(CmdArgs args)
        {
            var model = AsmBitfields.service().OpCodeField().Model;
            var buffer = span<char>(256);
            var i = 0u;
            var length = BitfieldSpecs.render(model, ref i, buffer, SegRenderStyle.Intel);
            var desc = text.format(slice(buffer,0,length));
            Write(desc);
            return true;
        }
    }
}