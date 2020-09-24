//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        public readonly struct AsmOperator
        {
            public readonly AsmOperatorCode Code;

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
}