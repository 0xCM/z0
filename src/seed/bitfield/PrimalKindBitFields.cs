//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PrimalKindField;
    using static Control;
    
    [ApiHost]
    public readonly struct PrimalKindBitFields : IApiHost<PrimalKindBitFields>
    {
        public static ReadOnlySpan<SegIndex> Indices
        {
            [MethodImpl(Inline), Op]
            get => cast<SegIndex>(FieldSegments);
        }

        public static ReadOnlySpan<SegMask> Masks
        {
            [MethodImpl(Inline), Op]
            get => cast<SegMask>(FieldMasks);
        }

        public static ReadOnlySpan<Field> Fields
        {
            [MethodImpl(Inline), Op]
            get => cast<Field>(FieldParts);
        }

        public static ReadOnlySpan<SegWidth> SegWidths
        {
            [MethodImpl(Inline), Op]
            get => Control.cast<SegWidth>(FieldWidths);
        }

        [MethodImpl(Inline), Op]
        public static PrimalKindBitField Init(PrimalKind data)
            => new PrimalKindBitField(data);

        [MethodImpl(Inline), Op]
        public static PrimalKindBitField Init(byte data)
            => new PrimalKindBitField(data);

        [MethodImpl(Inline), Op]
        public static SegMask Mask(Field i)
            => skip(Masks, (int)i);            

        [MethodImpl(Inline), Op]
        public static SegIndex StartPos(Field i)
            => skip(Indices, (int)i);

        [MethodImpl(Inline), Op]
        public static byte SegData(PrimalKindBitField f, Field i)
            => (byte)(((byte)Mask(i) & (byte)f.FieldValue) >> (int)StartPos(i));

        [MethodImpl(Inline), Op]
        public static Pow2Width Width(PrimalKindBitField f)
            => (Pow2Width)SegData(f, Field.Width);

        [MethodImpl(Inline), Op]
        public static PrimalKindId KindId(PrimalKindBitField f)
            => (PrimalKindId)SegData(f, Field.KindId);

        [MethodImpl(Inline), Op]
        public static Sign8Kind Sign(PrimalKindBitField f)
            => (Sign8Kind)SegData(f, Field.Sign);

        static ReadOnlySpan<byte> FieldMasks 
            => new byte[3]{(byte)SegMask.Width, (byte)SegMask.KindId, (byte)SegMask.Sign};

        static ReadOnlySpan<byte> FieldSegments
            => new byte[3]{(byte)SegIndex.Width, (byte)SegIndex.KindId, (byte)SegIndex.Sign};

        static ReadOnlySpan<byte> FieldParts
            => new byte[3]{(byte)Field.Width,(byte)Field.KindId, (byte)Field.Sign};

        static ReadOnlySpan<byte> FieldWidths
            => new byte[3]{(byte)SegWidth.Width,(byte)SegWidth.KindId, (byte)SegWidth.Sign};
    }
}