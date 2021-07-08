//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmLineSpec
    {
        readonly Index<AsmLinePart> _PartList;

        readonly Index<ushort> _PartWidths;

        [MethodImpl(Inline)]
        internal AsmLineSpec(AsmLinePart[] parts, ushort[] widths)
        {
            _PartList = parts;
            _PartWidths = widths;
        }

        public Span<AsmLinePart> PartList
        {
            [MethodImpl(Inline)]
            get => _PartList.Edit;
        }

        public Span<ushort> PartWidths
        {
            [MethodImpl(Inline)]
            get => _PartWidths.Edit;
        }


        public byte PartCount
        {
            [MethodImpl(Inline)]
            get => (byte)_PartList.Count;
        }
    }
}