//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static WsNames;

    partial class AsmCmdService
    {
        [CmdOp(".asm-tokens")]
        Outcome Tokens(CmdArgs args)
        {
            var result = Outcome.Success;
            Emit(AsmTokens.OpCodes.create());
            Emit(AsmTokens.Sigs.create());
            Emit(AsmTokens.Codes.create());
            Emit(AsmTokens.Bitfields.create());
            Emit(AsmTokens.Regs.create());
            Emit(AsmTokens.Conditions.create());

            return result;
        }

        void Emit(ITokenSet src)
        {
            var dst = Ws.Output().Table<SymToken>(queries, src.Name);
            var tokens = Symbols.tokens(src.Types());
            EmitRecords(tokens, SymToken.RenderWidths, dst);
        }
    }
}