//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static ConditionCodes;
    using static Blit;
    using static core;


    partial class AsmCmdService
    {
        [CmdOp(".cc")]
        Outcome SymString(CmdArgs args)
        {
            const string Pattern = "{0,-4} rel{1} [{2}:{3}b] => {4}";
            var result = Outcome.Success;
            var conditions = Conditions.create();
            var jcc = conditions.JccCodes(w8);
            var jccAlt = conditions.JccAltCodes(w8);
            var count = jcc.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(jcc,i);
                ref readonly var codeAlt = ref skip(jccAlt,i);
                ref readonly var name = ref conditions.Name(code);
                ref readonly var nameAlt = ref conditions.Name(codeAlt);
                ref readonly var info = ref conditions.Describe(code);
                ref readonly var infoAlt = ref conditions.Describe(codeAlt);

                var _jcc = asm.jcc(code, name, AsmSizeKind.@byte);
                var _jccAlt = asm.jcc(codeAlt, nameAlt, AsmSizeKind.@byte);

                var fmt = string.Format(Pattern, _jcc.Name, _jcc.Size.Width, HexFormat.asmhex(_jcc.Encoding), BitRender.format8x4(_jcc.Encoding), info);
                var fmtAlt = string.Format(Pattern, _jccAlt.Name, _jccAlt.Size.Width, HexFormat.asmhex(_jccAlt.Encoding), BitRender.format8x4(_jccAlt.Encoding), info);

                Write(fmt);
                if(name != nameAlt)
                    Write(fmtAlt);
            }

            return result;
        }
    }
}