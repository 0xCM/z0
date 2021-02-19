//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    readonly struct AsmExprFacets
    {
        public const char CompositeIndicator = Chars.FSlash;

        public const char OperandDelimiter = Chars.Comma;

        public const char MnemonicTerminator = Chars.Space;
    }
}