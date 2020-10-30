//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ApiNameAtoms;

    using A = ApiNameAtoms;


    [LiteralProvider]
    readonly struct ApiNames
    {
        public const string AsmData = asm + dot + data;

        const string opcodes = nameof(opcodes);

        public const string AsmOpCodes = AsmData + dot + opcodes;

        public const string AsmLang = asm + dot + lang;

        public const string AsmOperands =  AsmLang + dot + operands;

        public const string AsmMachines = asm + dot + machines;

        const string machines = nameof(machines);

        const string registers = nameof(registers);

        public const string RegisterQuery = asm + dot + registers + dot + query;
    }
}
