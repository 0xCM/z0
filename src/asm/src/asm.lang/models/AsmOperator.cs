//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmLang;

    public readonly struct AsmOperator : ISyntaxAtom<AsmOperator,AsmOperatorCode>
    {
        public AsmOperatorCode Code {get;}

        [MethodImpl(Inline)]
        public AsmOperator(AsmOperatorCode key)
            => Code = key;

        [MethodImpl(Inline)]
        public static implicit operator AsmOperator(AsmOperatorCode src)
            => new AsmOperator(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmOperatorCode(AsmOperator src)
            => src.Code;
    }
}