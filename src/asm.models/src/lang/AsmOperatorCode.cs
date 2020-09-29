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
        public enum AsmOperatorCode : byte
        {
            add = AsciMathCode.Add,

            sub = AsciMathCode.Sub,

            mul = AsciMathCode.Mul
        }
    }
}