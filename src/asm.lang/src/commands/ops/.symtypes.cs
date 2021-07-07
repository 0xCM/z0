//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".symtypes")]
        Outcome SymbolTypes(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = SymTypes.View;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var t = ref skip(src,i);
                Write(t.Name);
            }

            return result;
        }
    }
}