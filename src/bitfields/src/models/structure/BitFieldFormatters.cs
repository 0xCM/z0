//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct BitFieldFormatters : ILineFormatter<BitFieldModel>
    {
        public static BitFieldFormatters Service => default;
        
        public string Format(BitFieldModel src)
            => FormatLines(src).Intersperse("\r\n").Concat();

        public string[] FormatLines(BitFieldModel src)
        {
            var dst = new string[src.FieldCount];
            for(var i=0; i<src.FieldCount; i++)
            {
                var index = i;
                var indexLabel = index.ToString().PadLeft(2, Chars.D0);
                var name = src.Name(i);
                var width = src.Width(i);
                var widthLabel = width.ToString().PadLeft(2, Chars.D0);
                var left = src.Position(i);
                var leftLabel = left.ToString().PadLeft(2, Chars.D0);
                var right = left + width - 1;
                var rightLabel = right.ToString().PadLeft(2, Chars.D0);
                dst[i] = $"{src.BitFieldName} | {name} | {indexLabel} | {widthLabel} | [{leftLabel}..{rightLabel}]";
            }
            return dst;
        }
    }
}