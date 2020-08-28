//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Data;

    using static Konst;
    using static Root;
    using static XedSourceMarkers;
    using static As;

    using R = XedPatternSummary;
    using F = XedPatternField;

    static class PatternSummaryEtl
    {
        public static XedPattern[] ExtractPatterns(this XedInstructionData src)
        {
            var patterns = list<XedPattern>();
            for(var i=0; i<src.RowCount; i++)
            {
                if(src.IsProp(i,PATTERN) && i != (src.RowCount - 1))
                {
                    if(src.IsProp(i + 1, OPERANDS))
                    {
                        patterns.Add(new XedPattern(
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

        public static string ExtractProp(this XedInstructionData src, string name)
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
            return EmptyString;
        }

        public static string BaseCodeText(this XedPattern src)
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

        public static BinaryCode BaseCode(this XedPattern src)
        {
            var dst = 0ul;
            var pos = 0u;
            var parser = HexByteParser.Service;
            for(var i=0u; i<src.Parts.Length; i++)
            {
                var part = src.Parts[i];
                if(parser.HasPreSpec(part))
                    seek8(dst, pos++) = parser.ParseByte(part);
            }

            return slice(ByteReader.ReadAll(dst),0, pos);
        }

        const char LeftFence = Chars.LBracket;

        const char RightFence = Chars.RBracket;

        public static string Mod(this XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(MOD)).MapValueOrDefault(x => x.Unfence(LeftFence, RightFence), EmptyString);

        public static string Reg(this XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(REG)).MapValueOrDefault(x => x.Unfence(LeftFence, RightFence), EmptyString);

        public static XedPatternSummary Summary(this XedPattern src)
        {
            var modidx = src.Parts.TryFind(x => x.StartsWith(MODIDX)).MapValueOrDefault(x => x.RightOf(ASSIGN).Trim(), EmptyString);
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

        public static string FormatPattern(this XedPattern src, char delimiter)
        {
            var dst = TableFormat.formatter<F>(delimiter);
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

        public static string FormatRow(this XedPatternSummary src, char delimiter)
        {
            var dst = TableFormat.formatter<F>(delimiter);
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