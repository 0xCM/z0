//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines an offset label in an assembly listing
    /// </summary>
    public readonly struct AsmOffsetLabel
    {
        public ulong Offset {get;}

        public DataWidth Width {get;}

        public AsmOffsetLabel(DataWidth width, ulong offset)
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
            => AsmRender.offset(Offset, Width);

        public override string ToString()
            => Format();

        public static AsmOffsetLabel Empty
        {
            [MethodImpl(Inline)]
            get => new AsmOffsetLabel(0, 0);
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmLabel(AsmOffsetLabel src)
            => new AsmLabel(src.Format());
    }
}