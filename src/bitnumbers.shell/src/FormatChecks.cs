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
    using static Typed;
    using static BitNumbers;

    [ApiHost]
    class BitFormatChecks : AppService<BitFormatChecks>
    {
        BitNumberFormatter Formatter;

        Index<byte> _Data;

        Index<char> _Buffer;

        ReadOnlySpan<byte> Source
        {
            [MethodImpl(Inline)]
            get => _Data.View;
        }

        uint SourceCount;

        [MethodImpl(Inline)]
        string FormatBuffer(uint offset, uint length)
            => text.format(slice(_Buffer.View,offset,length));

        Span<char> RentBuffer()
            => _Buffer.Clear();

        public BitFormatChecks()
        {
            Formatter = new();
            _Buffer = alloc<char>(Pow2.T08);
        }

        public void Run(IPolySource src)
        {
            SourceCount = Pow2.T12;
            _Data = src.Bytes(SourceCount).Array();
            var data = _Data.Edit;

            var ComponentCount = n4;
            var ComponentWidth = w8;
            var ComponentSize = 1;
            var VectorSize = ComponentSize*4;

            var SampleCount = 4;

            for(var i=0; i<SampleCount; i++)
            {
                var segment = slice(data, i*VectorSize, VectorSize);
                var v = HexVector.create(ComponentCount, ComponentWidth, segment);
                Check(v);
            }

            // var outcome = Check(w3);
            // var formatter = Tables.formatter<FormatCheck<W3,uint3>>();
            // var target = Db.AppTablePath<FormatCheck<W3,uint3>>("checks");
            // using var writer = target.Writer();
            // writer.WriteLine(formatter.FormatHeader());
            // root.iter(outcome, o => writer.WriteLine(formatter.Format(o)));
        }

        public void Check(HexVector8<N4> src)
        {
            var offset = 0u;
            var buffer = RentBuffer();

            //seek(buffer,offset++) = Chars.Lt;
            offset += BitRender.render(src, offset, buffer);
            //seek(buffer, offset++) = Chars.Gt;

            Wf.Row(FormatBuffer(0, offset));
        }

        public void Check(W2 w)
        {

        }

        public Index<FormatCheck<W3,uint3>> Check(W3 w)
        {
            var buffer = alloc<FormatCheck<W3,uint3>>(SourceCount);
            Check(w, buffer);
            return buffer;
        }

        [Op]
        void Check(W3 w, Index<FormatCheck<W3,uint3>> dst)
        {
            var target = dst.Edit;
            for(var i=0u; i<SourceCount; i++)
            {
                var a = skip(Source,i);
                var b = BitNumbers.uint3(a);
                var c = Formatter.Format(b);
                seek(target,i) = result(w, i, a, b, c);
            }
        }

        public void Check(W4 w)
        {

        }

        public void Check(W5 w)
        {

        }

        public void Check(W6 w)
        {

        }

        public void Check(W7 w)
        {

        }

        public void Check(W8 w)
        {

        }

        [MethodImpl(Inline)]
        public static FormatCheck<W,T> result<W,T>(W w, uint seq,  byte input, T number, string formatted)
            where T : unmanaged, IBitNumber
            where W : unmanaged, IDataWidth
        {
            var dst = new FormatCheck<W,T>();
            dst.Sequence = seq;
            dst.Input = input;
            dst.Number = number;
            dst.Formatted = formatted;
            dst.LengthExpect = (byte)Widths.data(w);
            dst.LengthActual = (byte)formatted.Length;
            dst.LenthMatch = dst.LengthExpect == dst.LengthActual;
            return dst;
        }
    }
}