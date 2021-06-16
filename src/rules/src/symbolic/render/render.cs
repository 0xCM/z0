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
    using static SymbolicTools;

    partial struct SymbolicRender
    {
        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<AsciCode> src, ref uint i, Span<char> dst)
        {
            var count = (uint)src.Length;
            for(var j=0; j<count; j++)
                seek(dst,i++) = (char)skip(src,j);
            return count;
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<char> src, ref uint i, Span<char> dst)
        {
            var i0 = i;
            var count = (uint)src.Length;
            for(var j=0; j<count; j++)
                seek(dst,i++) = skip(src,j);
            return i-i0;
        }

        [Op]
        public static uint render(in BitfieldSeg src, ref uint i, Span<char> dst, SegRenderStyle style = default)
        {
            var i0 = i;
            copy(src.SegName.Format(), ref i, dst);
            seek(dst, i++) = Chars.Colon;
            render(src.Min, src.Max, style, ref i, dst);
            return i - i0;
        }

        [Op]
        static uint render(byte min, byte max, SegRenderStyle style, ref uint i, Span<char> dst)
        {
            var i0 = i;
            seek(dst, i++) = Chars.LBracket;
            var rMin = min.ToString();
            var rMax = max.ToString();
            if(style == SegRenderStyle.Intel)
            {
                copy(rMax, ref i, dst);
                seek(dst, i++) = Chars.Colon;
                copy(rMin, ref i, dst);
            }
            else
            {
                copy(rMin, ref i, dst);
                seek(dst, i++) = Chars.Comma;
                copy(rMax, ref i, dst);

            }
            seek(dst, i++) = Chars.RBracket;
            return i - i0;
        }

        [Op]
        public static uint render(in BitfieldSegs src, ref uint i, Span<char> dst, SegRenderStyle style = default)
        {
            var i0 = i;
            var segs = src.View;
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

        public static uint render(in BitfieldSection src, ref uint i, Span<char> dst, SegRenderStyle style = default)
        {
            var i0 = i;
            var segs = src.Segments;
            copy(src.Name.Format(), ref i, dst);
            seek(dst, i++) = Chars.LBracket;
            if(segs.Length == 0)
                copy("<empty>", ref i, dst);
            else
                render(segs, ref i, dst, style);
            seek(dst, i++) = Chars.RBracket;
            return i - i0;
        }

    }
}