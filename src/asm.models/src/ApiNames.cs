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

        public const string AsmCodes = AsmData + dot + "codes";

        public const string AsmLang = asm + dot + lang;

        public const string AsmOperands =  AsmLang + dot + operands;
    }
}
