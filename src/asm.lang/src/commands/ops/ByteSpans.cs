//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    using static Root;
    using static core;
    using static AsmCodes;

    partial class AsmCmdService
    {
        [CmdOp(".sigtokens")]
        public Outcome sigtokens(CmdArgs args)
        {
            var result = Outcome.Success;
            var name = arg(args, 0).Value;
            result = AsmSigs.TokenType(name, out var type);
            if(result.Fail)
                return argerror(name);

            var symbols = Symbols.untyped(type).View;
            var count = symbols.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(symbols,i);

                Row(string.Format("{0,-6} | {1,-8} | {2, -8} | {3}", symbol.Key,  symbol.Name, symbol.Expr, symbol.Description));
            }

            return result;
        }

    }
}