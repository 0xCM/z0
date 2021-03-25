//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOffsetLabel : IAsmOffsetLabel
    {
        public ulong Offset {get;}

        public DataWidth Width {get;}

        [MethodImpl(Inline)]
        internal AsmOffsetLabel(byte offset)
        {
            Offset = offset;
            Width = DataWidth.W8;
        }

        [MethodImpl(Inline)]
        internal AsmOffsetLabel(ushort offset)
        {
            Offset = offset;
            Width = DataWidth.W16;
        }

        [MethodImpl(Inline)]
        internal AsmOffsetLabel(uint offset)
        {
            Offset = offset;
            Width = DataWidth.W32;
        }

        [MethodImpl(Inline)]
        internal AsmOffsetLabel(ulong offset)
        {
            Offset = offset;
            Width = DataWidth.W64;
        }

        [MethodImpl(Inline)]
        AsmOffsetLabel(ulong offset, DataWidth width)
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
            => AsmRender.format(this);

        public override string ToString()
            => Format();

        public static AsmOffsetLabel Empty
        {
            [MethodImpl(Inline)]
            get => new AsmOffsetLabel(0, DataWidth.None);
        }
    }
}