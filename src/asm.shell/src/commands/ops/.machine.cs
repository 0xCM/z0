//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class AsmCmdService
    {
        [CmdOp(".asmgen")]
        Outcome Generate(CmdArgs args)
        {
            var result = Outcome.Success;
            result = EmitApiLiterals();
            if(result.Fail)
                return result;

            result = GenModRmBits();
            if(result.Fail)
                return result;

            result = GenSibBits();
            if(result.Fail)
                return result;

            return result;
        }

        [CmdOp(".machine")]
        Outcome EmitMachineTables(CmdArgs args)
        {
            var result = Outcome.Success;
            var tokens = Wf.AsmTokens();
            EmitTokens(tokens.RegTokens());
            EmitTokens(tokens.OpCodeTokens());
            EmitTokens(tokens.SigTokens());
            EmitTokens(tokens.ConditonTokens());
            var dst = Ws.Tables().Table(WsAtoms.machine,"classes.asm.operands");
            EmitSymKinds(Symbols.index<AsmOpClass>(),dst);
            EmitSymLiterals<AsmPrefixCodes.RexPrefixCode>(Ws.Tables().Table(WsAtoms.machine,"symbols.asm.prefix.rex"));
            return result;

        }

        void EmitTokens(ITokenSet src)
        {
            var dst = Ws.Tables().Table<SymToken>(WsAtoms.machine, src.Name);
            var tokens = Symbols.tokens(src.Types());
            TableEmit(tokens, SymToken.RenderWidths, dst);
        }


        ReadOnlySpan<SymLiteralRow> EmitSymLiterals<E>(FS.FilePath dst)
            where E : unmanaged, Enum
        {
            var svc = Wf.Symbolism();
            return svc.EmitLiterals<E>(dst);
        }
    }
}