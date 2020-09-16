//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Taken from, and corresponds to, the the Iced-defined Iced.Intel.FormatterTextKind
    /// </summary>
    public enum AsmFragmentKind
    {
        //
        // Summary:
        //     Normal text
        Text,
        //
        // Summary:
        //     Assembler directive
        Directive,
        //
        // Summary:
        //     Any prefix
        Prefix,
        //
        // Summary:
        //     Any mnemonic
        Mnemonic,
        //
        // Summary:
        //     Any keyword
        Keyword,
        //
        // Summary:
        //     Any operator
        Operator,
        //
        // Summary:
        //     Any punctuation
        Punctuation,
        //
        // Summary:
        //     Number
        Number,
        //
        // Summary:
        //     Any register
        Register,
        //
        // Summary:
        //     A decorator, eg. sae in {sae}
        Decorator,
        //
        // Summary:
        //     Selector value (eg. far JMP/CALL)
        SelectorValue,
        //
        // Summary:
        //     Label address (eg. JE XXXXXX)
        LabelAddress,
        //
        // Summary:
        //     Function address (eg. CALL XXXXXX)
        FunctionAddress,
        //
        // Summary:
        //     Data symbol
        Data,
        //
        // Summary:
        //     Label symbol
        Label,
        //
        // Summary:
        //     Function symbol
        Function
    }
}