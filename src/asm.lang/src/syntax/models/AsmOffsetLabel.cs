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
        public Identifier Name {get;}

        public ulong Offset {get;}

        public DataWidth Width {get;}

        internal AsmOffsetLabel(byte offset)
        {
            Offset = offset;
            Width = DataWidth.W8;
            Name = string.Format("_{0}", AsmRender.offset(Offset, Width));
        }

        internal AsmOffsetLabel(ushort offset)
        {
            Offset = offset;
            Width = DataWidth.W16;
            Name = string.Format("_{0}", AsmRender.offset(Offset, Width));
        }

        internal AsmOffsetLabel(uint offset)
        {
            Offset = offset;
            Width = DataWidth.W32;
            Name = string.Format("_{0}", AsmRender.offset(Offset, Width));
        }

        internal AsmOffsetLabel(ulong offset)
        {
            Offset = offset;
            Width = DataWidth.W64;
            Name = string.Format("_{0}", AsmRender.offset(Offset, Width));
        }

        AsmOffsetLabel(ulong offset, DataWidth width)
        {
            Offset = offset;
            Width = width;
            Name = string.Format("_{0}", AsmRender.offset(Offset, Width));
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
            => Name;

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