//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = XedPatternField;
    using R = XedPattern;

    public readonly struct XedPattern : ITabular<F,R>
    {
        public string Class {get;}

        public string Category {get;}

        public string Extension {get;}

        public string IsaSet {get;}

        public string PatternText {get;}

        public string OperandText {get;}

        public string[] Parts {get;}

        public string[] Operands  {get;}

        [MethodImpl(Inline)]
        public XedPattern(string @class, string category, string extension, string isaset, string patternText, string operandText)
        {
            Class = @class ?? string.Empty;
            Category = category ?? string.Empty;
            Extension = extension ?? string.Empty;
            IsaSet = isaset ?? string.Empty;
            PatternText = patternText ?? string.Empty;
            Parts = PatternText.SplitClean(Space);
            OperandText = operandText ?? string.Empty;
            Operands = OperandText.SplitClean(Space);
        }

        public string DelimitedText(char delimiter)
            => XedOps.format(this, delimiter);
    }
}