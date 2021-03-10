//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Part;

    [ApiHost]
    public readonly struct AsmLang : ILanguage<AsmLang>
    {
        const Z0.NumericKind Closure = UnsignedInts;

        public Name Id => "asm";

        [Op]
        public static string format(in AsmCallSite src)
            => string.Format("{0}:{1}", src.Caller, src.InstructionOffset);
    }
}