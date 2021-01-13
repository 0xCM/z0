//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmLang
    {
        public readonly struct Operator : ISyntaxAtom<Operator,OperatorCode>
        {
            public OperatorCode Code {get;}

            [MethodImpl(Inline)]
            public Operator(OperatorCode key)
                => Code = key;

            [MethodImpl(Inline)]
            public static implicit operator Operator(OperatorCode src)
                => new Operator(src);

            [MethodImpl(Inline)]
            public static implicit operator OperatorCode(Operator src)
                => src.Code;
        }
    }
}