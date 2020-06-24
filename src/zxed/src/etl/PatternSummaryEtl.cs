//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    using static Konst;
    using static Root;
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

        public static string BaseCodeText(this InstructionPattern src)
        {
            var dst = text.build();
            var count = src.Parts.Length;
            for(var i=0; i<count; i++)
            {
                var part = src.Parts[i];
                dst.Append(part);
                if(i != count - 1)
                    dst.Append(Chars.Space);
            }
            
            return dst.ToString();
        }   

        public static BinaryCode BaseCode(this InstructionPattern src)
        {
            var dst = 0ul;
            var pos = 0;
            var parser = HexByteParser.Service;
            for(var i=0; i<src.Parts.Length; i++)
            {
                var part = src.Parts[i];
                if(parser.HasPreSpec(part))
                    refs.seek8(ref dst, pos++) = parser.ParseByte(part);
            }

            return ByteReader.ReadAll(dst).Slice(0, pos);            
        }

        const char LeftFence = Chars.LBracket;

        const char RightFence = Chars.RBracket;
        
        public static string Mod(this InstructionPattern src)
            => src.Parts.TryFind(x => x.StartsWith(MOD)).MapValueOrDefault(x => x.Unfence(LeftFence, RightFence), string.Empty);

        public static string Reg(this InstructionPattern src)
            => src.Parts.TryFind(x => x.StartsWith(REG)).MapValueOrDefault(x => x.Unfence(LeftFence, RightFence), string.Empty);

        public static PatternSummary Summary(this InstructionPattern src)
        {
            var modidx = src.Parts.TryFind(x => x.StartsWith(MODIDX)).MapValueOrDefault(x => x.RightOf(ASSIGN).Trim(), string.Empty);
            return new R(
                Class: src.Class, 
                Category: src.Category, 
                Extension: src.Extension, 
                IsaSet: src.IsaSet, 
                BaseCode: src.BaseCode(),
                Mod: src.Mod(),
                Reg: src.Reg(),
                Pattern: src.PatternText, 
                Operands: src.OperandText);
        }

        public static string FormatPattern(this InstructionPattern src, char delimiter)
        {
            var dst =Tabular.FieldFormatter<F>(delimiter);
            dst.Delimit(F.Class, src.Class);
            dst.Delimit(F.Category, src.Category);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.IsaSet, src.IsaSet);
            dst.Delimit(F.BaseCode, src.BaseCode());
            dst.Delimit(F.Mod, src.Mod());
            dst.Delimit(F.Reg, src.Reg());
            dst.Delimit(F.Pattern, src.PatternText);
            dst.Delimit(F.Operands, src.Operands);
            return dst.Format();
        }

        public static string FormatRow(this PatternSummary src, char delimiter)
        {
            var dst = Tabular.FieldFormatter<F>(delimiter);
            dst.Delimit(F.Class, src.Class);
            dst.Delimit(F.Category, src.Category);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.IsaSet, src.IsaSet);
            dst.Delimit(F.BaseCode, src.BaseCode);
            dst.Delimit(F.Mod, src.Mod);
            dst.Delimit(F.Reg, src.Reg);
            dst.Delimit(F.Pattern, src.Pattern);
            dst.Delimit(F.Operands, src.Operands);
            return dst.Format();                             
        }      
    }
}