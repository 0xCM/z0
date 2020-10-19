//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = XedPatternField;
    using R = XedPatternRow;

    public readonly struct XedPatternRow : ITabular<F,R>
    {
        public readonly string Class;

        public readonly string Category;

        public readonly string Extension;

        public readonly string IsaSet;

        public readonly BinaryCode BaseCode;

        public readonly string Mod;

        public readonly string Reg;

        public readonly string Pattern;

        public readonly string Operands;

        public XedPatternRow(string Class, string Category, string Extension, string IsaSet, BinaryCode BaseCode, string Mod, string Reg, string Pattern, string Operands)
        {
            this.Class = Class;
            this.Category = Category;
            this.Extension = Extension;
            this.IsaSet = IsaSet;
            this.Mod = Mod;
            this.Pattern = Pattern;
            this.Reg = Reg;
            this.Operands = Operands;
            this.BaseCode = BaseCode;
        }

        public string DelimitedText(char sep)
            => XedWfOps.format(this,sep);
    }
}