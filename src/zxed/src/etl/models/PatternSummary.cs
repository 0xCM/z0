//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    
    using static Tabular;

    using F = PatternField;
    using R = PatternSummary;


    public enum PatternField : uint
    {
        Class = 0 | 20u << WidthOffset,

        Category = 1 | 14u << WidthOffset,

        Extension = 2 | 14u << WidthOffset,

        IsaSet = 3 | 14u << WidthOffset,

        BaseCode = 4 | 12u << WidthOffset,
        
        Mod = 5 | 10u << WidthOffset,
        
        Reg = 6 | 10u << WidthOffset,

        Pattern = 7 | 100u << WidthOffset,

        Operands = 9 | 0u << WidthOffset,        
    }

    public readonly struct PatternSummary : ITabular<F,R>
    {        
        public static PatternSummary Empty 
            => new PatternSummary(string.Empty, string.Empty, string.Empty, string.Empty, 
                    BinaryCode.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        
        public static implicit operator Tabular<F,R>(PatternSummary src)
            => src.Generalized;

        public Tabular<F,R> Generalized 
            => new Tabular<F,R>();

        [TabularField(F.Class)]
        public readonly string Class;

        [TabularField(F.Category)]
        public readonly string Category;

        [TabularField(F.Extension)]
        public readonly string Extension;

        [TabularField(F.IsaSet)]
        public readonly string IsaSet;        

        [TabularField(F.BaseCode)]
        public readonly BinaryCode BaseCode;

        [TabularField(F.Mod)]
        public readonly string Mod;        

        [TabularField(F.Reg)]
        public readonly string Reg;

        [TabularField(F.Pattern)]
        public readonly string Pattern;        

        [TabularField(F.Operands)]
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