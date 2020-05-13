//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;
    using static Props;

    partial class Res
    {    
        public readonly struct PatternOps
        {
            public string Class {get;}

            public string Category {get;}

            public string Extension {get;}

            public string IsaSet {get;}

            public string PatternText {get;}

            public string OperandText {get;}

            public string[] PatternParts => PatternText.SplitClean(Chars.Space);
            
            public string[] Operands => OperandText.SplitClean(Chars.Space);

            [MethodImpl(Inline)]
            public static PatternOps Create(string @class, string category, string ext, string isaset, string pattern, string operands)
                => new PatternOps(@class, category, ext, isaset, pattern, operands);

            [MethodImpl(Inline)]
            public PatternOps(string @class, string category, string ext, string isaset, string pattern, string operands)
            {
                Class = @class ?? string.Empty;
                Category = category ?? string.Empty;
                Extension = ext ?? string.Empty;
                IsaSet = isaset ?? string.Empty;
                PatternText = pattern ?? string.Empty;
                OperandText = operands ?? string.Empty;
            }
        }   
    }
}