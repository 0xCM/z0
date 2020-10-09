//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static XedSourceMarkers;
    using static z;

    static class PatternSummaryEtl
    {
        public static string ExtractProp(this XedInstructionDoc src, string name)
        {
            for(var i=0; i<src.RowCount; i++)
            {
                var row = src.Data[i];
                var rowText = row.Text;
                if(text.nonempty(rowText) && rowText.StartsWith(name))
                {
                    var value = rowText.RightOfFirst(PROP_DELIMITER);
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

            return slice(ByteRead.ReadAll(dst),0, pos);
        }

        const char LeftFence = Chars.LBracket;

        const char RightFence = Chars.RBracket;

        public static string Mod(this XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(MOD)).MapValueOrDefault(x => x.Unfence(LeftFence, RightFence), EmptyString);

        public static string Reg(this XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(REG)).MapValueOrDefault(x => x.Unfence(LeftFence, RightFence), EmptyString);
    }
}