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
        readonly StringRef FieldName;

        public readonly byte FieldCount;

        public readonly byte TotalWidth;

        readonly ArraySpan<byte> Widths;

        readonly TableSpan<StringRef> Names;

        readonly ArraySpan<byte> Positions;

        [MethodImpl(Inline)]
        public BitFieldModel(string name, byte count, byte width, string[] names,  byte[] widths, byte[] positions)
        {
            FieldName = name;
            FieldCount = count;
            TotalWidth = width;
            Names = names.Select(n => StringRefs.@ref(n));
            Widths = widths;
            Positions = positions;
        }

        public string BitFieldName
        {
            [MethodImpl(Inline)]
            get => FieldName;
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