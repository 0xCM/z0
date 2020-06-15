//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = PatternField;
    using R = PatternSummary;

    public readonly struct PatternSummary : ITabular<F,R>
    {        
        public static PatternSummary Empty 
            => new PatternSummary(EmptyString, EmptyString, EmptyString, EmptyString, 
                    BinaryCode.Empty, EmptyString, EmptyString, EmptyString, EmptyString);
        
        public readonly string Class;

        public readonly string Category;

        public readonly string Extension;

        public readonly string IsaSet;        

        public readonly BinaryCode BaseCode;

        public readonly string Mod;        

        public readonly string Reg;

        public readonly string Pattern;        

        public readonly string Operands;        
        
        public PatternSummary(string Class, string Category, string Extension, string IsaSet, BinaryCode BaseCode,  string Mod, string Reg, string Pattern, string Operands)
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
            => this.FormatRow(sep);
    }   
}