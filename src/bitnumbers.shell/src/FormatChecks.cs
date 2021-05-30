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
            => text.format(slice(_Buffer.View, offset, length));

        Span<char> RentBuffer()
            => _Buffer.Clear();

        public BitFormatChecks()
        {
            Formatter = new();
            _Buffer = alloc<char>(Pow2.T08);
        }

        void Check1(IPolySource src)
        {
            SourceCount = Pow2.T12;
            _Data = src.Bytes(SourceCount).Array();
            var data = _Data.Edit;

            var n = n4;
            var w = w8;
            var cSize = w/8;
            var vSize = cSize*4;

            var SampleCount = 24;

            for(var i=0; i<SampleCount; i++)
            {
                var segment = slice(data, i*vSize, vSize);
                var vector = HexVector.create(n, w, segment);
                Show(vector);
            }

        }

        public void Run(IPolySource src)
        {
            Check2();

        }


       // | mov rax,293f3942e98h | 48 b8 98 2e 94 f3 93 02 00 00  => 0100 1000 1011 1000 1001 1000 0010 1110 1001 0100 1111 0011 1001 0011 0000 0010 0000 0000 0000 0000                              | located://asm/apiextractor?block#block_(ApiMemberCode~in,ExtractTermInfo)

        static ReadOnlySpan<byte> MovSpec
            => new byte[10]{0x48, 0xb8, 0x98, 0x2e, 0x94, 0xf3, 0x93, 0x02, 0x00, 0x00};

        void Check2()
        {
            var vBuffer = Cells.alloc(w128).Bytes;
            MovSpec.CopyTo(vBuffer);
            var vector = HexVector.create(w8, vBuffer, n10);
            var hex = vector.Format();
            var cBuffer = CharBlocks.alloc(n128).Data;
            //var len = HexVector.bitstring(vector, cBuffer);
            var len = BitRender.render<N10>(n8, n8, vector.Bytes, 0u, cBuffer);
            var s = new string(slice(cBuffer,0,len));
            Wf.Row(hex);
            Wf.Row(s);

            var buf2 = CharBlocks.alloc(n128).Data;
            var x2 = first(recover<uint>(MovSpec.Slice(0,4)));
            Wf.Row(x2.FormatHexBytes());
            var l2 = BitRender.render(n32,n8,x2,0,buf2);
            var s2 = new string(slice(buf2, 0, l2));
            Wf.Row(l2);
            Wf.Row(s2);
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