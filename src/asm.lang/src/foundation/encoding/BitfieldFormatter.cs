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

    [ApiHost]
    public readonly ref struct BitfieldFormatter
    {
        readonly ReadOnlySpan<byte> Indices;

        readonly ReadOnlySpan<byte> Widths;

        readonly byte FieldCount;

        readonly Span<char> Buffer;

        public BitfieldFormatter(AsmBitfield src)
        {
            Indices = src.Indices;
            Widths = src.Widths;
            Buffer = sys.alloc<char>(64);
            FieldCount = src.FieldCount;
        }

        [Op, MethodImpl(Inline)]
        void Clear()
        {
            first(recover<char,CharBlock64>(Buffer)) = default;
        }

        [Op]
        public ReadOnlySpan<char> Format(byte src)
        {
            Clear();
            var bits = slice(cpu.vsrl(cpu.vmask128x8u(src),7).ToCell().Bytes,0,8);
            return Format(bits);
        }

        ReadOnlySpan<char> Format(Span<byte> bits)
        {
            var k = 0;
            for(var i=FieldCount - 1; i>=0; i--)
            {
                var index = skip(Indices,i);
                var width = skip(Widths,i);
                var segment = slice(bits,index,width);
                for(var j=width-1; j>=0; j--)
                    seek(Buffer,k++) = bit.test(skip(segment,j),0).ToChar();
                seek(Buffer,k++) = Chars.Space;
            }
            return slice(Buffer,0,k);
        }
    }
}