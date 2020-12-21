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

        public string DelimitedText(char sep)
            => XedWfOps.format(this,sep);
    }
}