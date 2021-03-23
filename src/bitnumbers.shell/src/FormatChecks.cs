//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static BitNumbers;

    [ApiHost]
    class BitFormatChecks : WfService<BitFormatChecks>
    {
        BitNumberFormatter Formatter;

        Index<byte> _Data;

        ReadOnlySpan<byte> Source
        {
            [MethodImpl(Inline)]
            get => _Data.View;
        }

        uint SourceCount;

        public BitFormatChecks()
        {
            Formatter = new();
        }

        public void Run(IPolySource src)
        {
            SourceCount = Pow2.T12;
            _Data = src.Bytes(SourceCount).Array();

            var outcome = Check(w3);
            var formatter = Records.formatter<FormatCheck<W3,uint3>>();
            var target = Db.AppTablePath<FormatCheck<W3,uint3>>("checks");
            using var writer = target.Writer();
            writer.WriteLine(formatter.FormatHeader());
            root.iter(outcome, o => writer.WriteLine(formatter.Format(o)));
        }

        public void Check(W1 w)
        {

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