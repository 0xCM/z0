//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmOffsetLabel : IAsmOffsetLabel
    {
        public Identifier Name {get;}

        public TextBlock OffsetText {get;}

        public ulong Offset {get;}

        public DataWidth Width {get;}

        internal AsmOffsetLabel(ushort offset)
        {
            Offset = offset;
            Width = DataWidth.W16;
            OffsetText = AsmRender.offset(Offset, Width);
            Name = string.Format("_{0}", OffsetText);
        }

        AsmOffsetLabel(ulong offset, DataWidth width)
        {
            Offset = offset;
            Width = width;
            OffsetText = AsmRender.offset(Offset, Width);
            Name = string.Format("_{0}", OffsetText);
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
            => OffsetText;

        public override string ToString()
            => Format();

        public static AsmOffsetLabel Empty
        {
            [MethodImpl(Inline)]
            get => new AsmOffsetLabel(0, DataWidth.None);
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmLabel(AsmOffsetLabel src)
            => new AsmLabel(src.Name);
    }
}