//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmLineLabel
    {
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
    }

}