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
            => text.format(slice(_Buffer.View, offset, length));

        Span<char> RentBuffer()
            => _Buffer.Clear();

        public BitFormatChecks()
        {
            Formatter = new();
            _Buffer = alloc<char>(Pow2.T08);
        }

        void CheckNibbleSpan()
        {
            var m0 =  Cells.cell64(BitMaskLiterals.Even64);
            var m1 = Cells.cell64(BitMaskLiterals.Lsb63x3x1);
            var storage = Cells.join(m0,m1);
            var bytes = storage.Bytes;
            var bits = BitRender.render8x8(bytes);
            Wf.Row(text.format(bits));

            var nibbles = BitNumbers.nibbles(bytes);
            var count = nibbles.Count;
            Wf.Row(string.Format("{0}:{1}", "Count", count));
            if(count != 32)
                return;

            var dst = text.buffer();
            dst.Append("[");
            for(var i=0; i<count; i++)
            {
                var cell = nibbles[i];
                dst.Append(cell.Format());
                if(i != count - 1)
                    dst.Append(" | ");
            }
            dst.Append("]");

            Wf.Row(dst.Emit());
        }

        public void Run(IPolySource src)
        {
            CheckNibbleSpan();
            Check(w3);
        }

        public void Show(HexVector8<N4> src)
        {
            Wf.Row(src.Format());

            var offset = 0u;
            var buffer = RentBuffer();
            offset += src.Bitstring(offset, buffer);

            seek(buffer, offset++) = Chars.Space;
            seek(buffer, offset++) = Chars.Eq;
            seek(buffer, offset++) = Chars.Space;

            offset += HexVector.bitstring(src, offset, buffer);

            Wf.Row(FormatBuffer(0, offset));
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