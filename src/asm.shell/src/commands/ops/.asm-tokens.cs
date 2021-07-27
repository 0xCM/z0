//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".asm-tokens")]
        Outcome Tokens(CmdArgs args)
        {
            var result = Outcome.Success;
            var sigs = AsmTokens.Sigs.create().Types();
            iter(sigs,x => EmitTokens(x));
            var opcodes = AsmTokens.OpCodes.create().Types();
            iter(opcodes,x => EmitTokens(x));
            var codes = AsmTokens.Codes.create().Types();
            iter(codes,x => EmitTokens(x));
            return result;
        }

        void EmitTokens(Type definition)
        {
            var src = Symbols.untyped(definition).View;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(src,i);
                Write(string.Format("{0,-16} | {1,-6} | {2,-8} | {3, -8} | {4}", definition.Name, symbol.Key,  symbol.Name, symbol.Expr, symbol.Description));
            }
        }
    }
}