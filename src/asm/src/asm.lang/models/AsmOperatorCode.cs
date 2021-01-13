//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    public enum AsmOperatorCode : byte
    {
        add = AsciMathCode.Add,

        sub = AsciMathCode.Sub,

        mul = AsciMathCode.Mul
    }
}