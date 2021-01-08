//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct AsmLang
    {
        public enum OperatorCode : byte
        {
            add = AsciMathCode.Add,

            sub = AsciMathCode.Sub,

            mul = AsciMathCode.Mul
        }
    }
}