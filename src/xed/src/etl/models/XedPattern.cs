//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Record]
    public struct XedPattern : IRecord<XedPattern>
    {
        public string Class;

        public string Category;

        public string Extension;

        public string IsaSet;

        public string PatternText;

        public string OperandText;

        public string[] Parts;

        public string[] Operands;

        // [MethodImpl(Inline)]
        // public XedPattern(string @class, string category, string extension, string isaset, string patternText, string operandText)
        // {
        //     Class = @class ?? string.Empty;
        //     Category = category ?? string.Empty;
        //     Extension = extension ?? string.Empty;
        //     IsaSet = isaset ?? string.Empty;
        //     PatternText = patternText ?? string.Empty;
        //     Parts = PatternText.SplitClean(Space);
        //     OperandText = operandText ?? string.Empty;
        //     Operands = OperandText.SplitClean(Space);
        // }
    }
}