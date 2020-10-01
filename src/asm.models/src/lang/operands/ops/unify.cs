//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        partial struct Operands
        {
            [MethodImpl(Inline)]
            public static Operand<T> unify<T>(T src)
                where T : unmanaged, IOperand<T>
                    => src;
        }
    }
}