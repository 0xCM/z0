//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public struct AsmHexCode
    {
        [MethodImpl(Inline), Op]
        public static AsmHexCode load(ReadOnlySpan<byte> src)
        {
            var cell = Cells.alloc(w128);
            var count = (byte)root.min(src.Length, 15);
            var dst = bytes(cell);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            Cells.cell8(cell, 15) = count;
            return new AsmHexCode(cell);
        }

        [Op]
        public static bool parse(string src, out AsmHexCode dst)
        {
            var parser = HexByteParser.Service;
            if(parser.Parse(src, out var data))
            {
                dst = data;
                return true;
            }
            else
            {
                dst = AsmHexCode.Empty;
                return false;
            }
        }

        [Op]
        public static AsmHexCode parse(string src)
        {
            var dst = AsmHexCode.Empty;
            parse(src, out dst);
            return dst;
        }

        Cell128 Data;

        [MethodImpl(Inline)]
        internal AsmHexCode(Cell128 data)
            => Data = data;

        public byte Size
        {
            [MethodImpl(Inline)]
            get => Cells.cell8(Data, 15);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => slice(bytes(Data), 0, 15);
        }

        [MethodImpl(Inline)]
        public ref byte Cell(byte index)
            => ref first(Bytes);

        [MethodImpl(Inline)]
        public ushort ToUInt16()
            => (ushort)Data.Lo;

        [MethodImpl(Inline)]
        public uint ToUInt32()
            => (uint)Data.Lo;

        [MethodImpl(Inline)]
        public uint ToUInt64()
            => (uint)Data.Lo;

        public string Format()
            => Data.FormatHexData(Size);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(BinaryCode src)
            => load(src.View);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(ReadOnlySpan<byte> src)
            => load(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(byte[] src)
            => load(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmHexCode(string src)
            => parse(src);

        public static AsmHexCode Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}