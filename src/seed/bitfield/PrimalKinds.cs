//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static PrimalKindSpecs;

    [ApiHost]
    public readonly struct PrimalKinds : IApiHost<PrimalKinds> 
    {
        public static PrimalKinds Service => default;

        [MethodImpl(Inline), Op]
        public static byte FieldIndex(PrimalKindFieldSpec spec)
            => (byte)spec;

        [MethodImpl(Inline), Op]
        public static byte FieldWidth(PrimalKindFieldSpec spec)
            => (byte)((uint)spec >> 16);

        public ReadOnlySpan<SegIndex> Indices
        {
            [MethodImpl(Inline), Op]
            get => Control.cast<SegIndex>(SegmentData);
        }

        public ReadOnlySpan<SegMask> Masks
        {
            [MethodImpl(Inline), Op]
            get => Control.cast<SegMask>(MaskData);
        }

        public ReadOnlySpan<Field> Fields
        {
            [MethodImpl(Inline), Op]
            get => Control.cast<Field>(FieldData);
        }

        public ReadOnlySpan<SegWidth> SegWidths
        {
            [MethodImpl(Inline), Op]
            get => Control.cast<SegWidth>(WidthData);
        }

        [MethodImpl(Inline), Op]
        public PrimalKindFields Init(PrimalKind data)
            => new PrimalKindFields(new PrimalKindField(data));

        [MethodImpl(Inline), Op]
        public PrimalKindFields Init(byte data)
            => new PrimalKindFields(new PrimalKindField(data));

        [MethodImpl(Inline), Op]
        public SegMask Mask(Field i)
            => Control.skip(Masks, (int)i);            

        [MethodImpl(Inline), Op]
        public SegIndex StartPos(Field i)
            => Control.skip(Indices, (int)i);

        [MethodImpl(Inline), Op]
        public byte SegData(PrimalKindField f, Field i)
            => (byte)(((byte)Mask(i) & (byte)f.FieldValue) >> (int)StartPos(i));

        ReadOnlySpan<byte> MaskData 
            => new byte[3]{(byte)SegMask.Width, (byte)SegMask.KindId, (byte)SegMask.Sign};

        ReadOnlySpan<byte> SegmentData
            => new byte[3]{(byte)SegIndex.Width, (byte)SegIndex.KindId, (byte)SegIndex.Sign};

        ReadOnlySpan<byte> FieldData
            => new byte[3]{(byte)Field.Width,(byte)Field.KindId, (byte)Field.Sign};

        ReadOnlySpan<byte> WidthData
            => new byte[3]{(byte)SegWidth.Width,(byte)SegWidth.KindId, (byte)SegWidth.Sign};
    }
}