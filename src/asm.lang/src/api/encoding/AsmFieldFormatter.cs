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

    [ApiHost]
    public readonly ref struct AsmFieldFormatter
    {
        readonly ReadOnlySpan<byte> Widths;

        readonly byte FieldCount;

        readonly Span<char> Buffer;

        public AsmFieldFormatter(AsmBitfield src)
        {
            Widths = src.Widths;
            Buffer = new char[128];
            FieldCount = src.FieldCount;
        }

        [Op, MethodImpl(Inline)]
        void Clear()
        {
            Buffer.Clear();
        }

        [Op]
        public ReadOnlySpan<char> Format(ushort src)
        {
            Clear();
            return Render(cpu.vsrl(BitMasks.vmask128x8u(src), 7).ToCell().Bytes);
        }

        ReadOnlySpan<char> Render(Span<byte> bits)
        {
            var k = z8;
            var offset = 0u;
            for(var i=0; i<FieldCount; i++)
            {
                ref readonly var width = ref skip(Widths,i);
                var segment = slice(bits, offset, width);
                for(var j=0; j<width; j++)
                    seek(Buffer, k++) = bit.test(skip(segment,j),0).ToChar();

                segment.Reverse();

                offset += width;
                if(i != FieldCount - 1)
                    seek(Buffer, k++) = Chars.Space;
            }

            var result = slice(Buffer,0,k);
            result.Reverse();
            return result;
        }

    }
}