//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;
    using static Tabular;
    using static Res;
    using static SourceMarkers;

    using R = PatternSummary;
    using F = PatternField;

    static class PatternSummaryEtl
    {
        public static InstructionPattern[] ExtractPatterns(this InstructionData src)
        {
            var patterns = list<InstructionPattern>();
            for(var i=0; i<src.RowCount; i++)
            {
                if(src.IsProp(i,PATTERN) && i != (src.RowCount - 1))
                {
                    if(src.IsProp(i + 1, OPERANDS))
                    {
                        patterns.Add(new InstructionPattern(
                            src.Class, 
                            src.Category, 
                            src.Extension, 
                            src.IsaSet, 
                            src.ExtractProp(i), 
                            src.ExtractProp(i + 1)
                            ));
                    }
                }
            }
            return patterns.ToArray();
        }

        public static string ExtractProp(this InstructionData src, string name)
        {
            for(var i=0; i<src.RowCount; i++)
            {
                var row = src.Rows[i];
                var rowText = row.Text;
                if(text.nonempty(rowText) && rowText.StartsWith(name))
                {                    
                    var value = rowText.RightOf(PROP_DELIMITER);
                    if(text.nonempty(value))
                        return value.Trim();
                }                    
            }
            return string.Empty;
        }

        public static BinaryCode PatternBytes(this InstructionPattern src)
        {
            var dst = 0ul;
            var pos = 0;
            var parser = HexParsers.Bytes;
            for(var i=0; i<src.Parts.Length; i++)
            {
                var part = src.Parts[i];
                if(parser.HasPreSpec(part))
                    Seeker.seek8(ref dst, pos++) = parser.Succeed(part);                    
            }

            return ByteReader.ReadAll(dst).Slice(0, pos);
            
        }
        public static PatternSummary Summary(this InstructionPattern src)
        {
            var modidx = src.Parts.TryFind(x => x.StartsWith(MODIDX)).MapValueOrDefault(x => x.RightOf(ASSIGN).Trim(), string.Empty);
            return new R(
                Class: src.Class, 
                Category: src.Category, 
                Extension: src.Extension, 
                IsaSet: src.IsaSet, 
                BaseCode: src.PatternBytes(),
                Mod: src.Parts.TryFind(x => x.StartsWith(MOD)).MapValueOrDefault(x => x.Unfence(Chars.LBracket, Chars.RBracket), string.Empty), 
                Reg: src.Parts.TryFind(x => x.StartsWith(REG)).MapValueOrDefault(x => x.Unfence(Chars.LBracket, Chars.RBracket), string.Empty), 
                Pattern: src.PatternText, 
                Operands: src.OperandText);
        }

        public static string FormatRow(this PatternSummary src, char delimiter)
        {
            var dst = formatter<F>();
            dst.DelimitField(F.Class, src.Class);
            dst.DelimitField(F.Category, src.Category);
            dst.DelimitField(F.Extension, src.Extension);
            dst.DelimitField(F.IsaSet, src.IsaSet);
            dst.DelimitField(F.BaseCode, src.BaseCode);
            dst.DelimitField(F.Mod, src.Mod);
            dst.DelimitField(F.Reg, src.Reg);
            dst.DelimitField(F.Pattern, src.Pattern);
            dst.DelimitField(F.Operands, src.Operands);
            return dst.Format();                             
        }      
    }

}