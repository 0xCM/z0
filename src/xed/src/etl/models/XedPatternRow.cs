//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using F = XedPatternField;
    using R = XedPatternRow;

    public struct XedPatternRow : ITabular<F,R>
    {
        public string Class;

        public string Category;

        public string Extension;

        public string IsaSet;

        public BinaryCode BaseCode;

        public string Mod;

        public string Reg;

        public string Pattern;

        public string Operands;

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