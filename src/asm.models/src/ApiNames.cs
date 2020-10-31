//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ApiNameParts;

    [LiteralProvider]
    readonly struct ApiNames
    {
        public const string AsmData = asm + dot + data;

        public const string AsmOpCodes = AsmData + dot + opcodes;

        public const string AsmLang = asm + dot + lang;

        public const string AsmOperands =  AsmLang + dot + operands;

        public const string AsmMachines = asm + dot + machines;

        public const string RegisterQuery = asm + dot + registers + dot + query;
    }
}
