//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmLineLabel : IAsmDocPart<AsmLineLabel>
    {
        [Op]
        public static string format(in AsmLineLabel src)
            => src.Width switch{
                DataWidth.W8 => ScalarCast.uint8(src.Offset).FormatAsmHex(),
                DataWidth.W16 => ScalarCast.uint16(src.Offset).FormatAsmHex(),
                DataWidth.W32 => ScalarCast.uint32(src.Offset).FormatAsmHex(),
                DataWidth.W64 => src.Offset.FormatAsmHex(),
                _ => EmptyString
            };

        public ulong Offset {get;}

        public DataWidth Width {get;}

        public AsmDocPartKind Kind
            => AsmDocPartKind.LineLabel;

        [MethodImpl(Inline)]
        internal AsmLineLabel(byte offset)
        {
            Offset = offset;
            Width = DataWidth.W8;
        }

        [MethodImpl(Inline)]
        internal AsmLineLabel(ushort offset)
        {
            Offset = offset;
            Width = DataWidth.W16;
        }

        [MethodImpl(Inline)]
        internal AsmLineLabel(uint offset)
        {
            Offset = offset;
            Width = DataWidth.W32;
        }

        [MethodImpl(Inline)]
        internal AsmLineLabel(ulong offset)
        {
            Offset = offset;
            Width = DataWidth.W64;
        }

        [MethodImpl(Inline)]
        AsmLineLabel(ulong offset, DataWidth width)
        {
            Offset = offset;
            Width = width;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Width == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Width != 0;
        }

        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        public static AsmLineLabel Empty
        {
            [MethodImpl(Inline)]
            get => new AsmLineLabel(0, DataWidth.None);
        }
    }
}