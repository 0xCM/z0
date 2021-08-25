//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitfieldSpecs
    {
        public static string format(in BitfieldSeg src)
        {
            const string SegPattern = "{0}[{1}]:{2} = [{3}]";
            var datatype = src.Width == 1 ? nameof(bit) : string.Format("uint{0}", src.Width);
            var i = endpos(src.Offset, src.Width);
            var section = src.Width == 1 ? string.Format("{0}", src.Offset) : string.Format("{0}:{1}", i, src.Offset);
            return string.Format(SegPattern,
                src.SegName,
                src.SegPos,
                datatype,
                section);
        }


        [Op]
        public static uint render(in BitfieldSeg src, ref uint i, Span<char> dst, SegRenderStyle style = default)
        {
            var i0 = i;
            text.copy(src.SegName.Format(), ref i, dst);
            render(src.Offset, src.Width, style, ref i, dst);
            return i - i0;
        }

        public static uint render(ReadOnlySpan<BitfieldSeg> segs, ref uint i, Span<char> dst, SegRenderStyle style = default)
        {
            var i0 = i;
            var count = segs.Length;
            for(var j=count-1; j>=0; j--)
            {
                ref readonly var seg = ref skip(segs, j);
                render(seg, ref i, dst, style);
                if(j != 0)
                {
                    seek(dst, i++) = Chars.Space;
                    seek(dst, i++) = Chars.Pipe;
                    seek(dst, i++) = Chars.Space;
                }

            }
            return i - i0;
        }

        public static uint render(in BitfieldModel src, ref uint i, Span<char> dst, SegRenderStyle style = default)
        {
            var i0 = i;
            var segs = src.Segments;
            text.copy(src.Name.Format(), ref i, dst);
            seek(dst, i++) = Chars.LBrace;
            if(segs.Length == 0)
                text.copy("<empty>", ref i, dst);
            else
                render(segs, ref i, dst, style);
            seek(dst, i++) = Chars.RBrace;
            return i - i0;
        }

        [Op]
        static uint render(uint min, uint max, SegRenderStyle style, ref uint i, Span<char> dst)
        {
            var i0 = i;
            seek(dst, i++) = Chars.LBracket;
            var rMin = min.ToString();
            var rMax = max.ToString();
            if(style == SegRenderStyle.Intel)
            {
                text.copy(rMax, ref i, dst);
                seek(dst, i++) = Chars.Colon;
                text.copy(rMin, ref i, dst);
            }
            else
            {
                text.copy(rMin, ref i, dst);
                seek(dst, i++) = Chars.Comma;
                text.copy(rMax, ref i, dst);

            }
            seek(dst, i++) = Chars.RBracket;
            return i - i0;
        }
    }
}