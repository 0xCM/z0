//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BitFieldModel
    {
        readonly asci16 FieldName;

        public readonly byte FieldCount;

        public readonly byte TotalWidth;

        readonly ArraySpan<byte> Widths;

        readonly ArraySpan<asci16> Names;

        readonly ArraySpan<byte> Positions;

        [MethodImpl(Inline)]
        public BitFieldModel(asci16 name, byte count, byte width, ArraySpan<asci16> names,  ArraySpan<byte> widths, ArraySpan<byte> positions)
        {
            FieldName = name;
            FieldCount = count;
            TotalWidth = width;
            Names = names;
            Widths = widths;
            Positions = positions;
        }

        public string BitFieldName
        {
            [MethodImpl(Inline)]
            get => FieldName.Format().Trim();
        }

        [MethodImpl(Inline)]
        public byte Width(int index)
            => Widths[index];

        [MethodImpl(Inline)]
        public string Name(int index)
            => Names[index].Format();

        [MethodImpl(Inline)]
        public byte Position(int index)
            => Positions[index];
    }
}