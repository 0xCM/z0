//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static XedModels;

    partial class AsmCmdService
    {
        [CmdOp(".xed-forms")]
        Outcome XedForms(CmdArgs args)
        {
            var match = arg(args,0).Value;
            var forms = Symbols.index<IFormType>().View;
            var count = forms.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(forms,i);
                var expr = symbol.Expr;
                if(expr.Text.Contains(match,StringComparison.InvariantCultureIgnoreCase))
                {
                    Write(symbol.Expr);
                }
            }
            return true;
        }
    }
}