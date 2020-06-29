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
    using static Root;
    
    [ApiHost]
    public readonly struct PrimalKindBitFields
    {
        public const byte TotalWidth
            = (byte)SegWidth.KindId + (byte)SegWidth.Width + (byte)SegWidth.Sign;

        [MethodImpl(Inline), Op]
        public static PrimalKindBitField define(PrimalKind data)
            => new PrimalKindBitField(data);

        [MethodImpl(Inline), Op]
        public static PrimalKindBitField define(byte data)
            => new PrimalKindBitField(data);

        [MethodImpl(Inline), Op]
        public static TypeCode code(PrimalKindBitField f)
            => (TypeCode)segval(f, SegField.KindId);

        [MethodImpl(Inline), Op]
        public static byte width(PrimalKindBitField f)
            => segval(f, SegField.Width);

        [MethodImpl(Inline), Op]
        public static SignKind sign(PrimalKindBitField f)
            => (SignKind)segval(f, SegField.Sign);

        [MethodImpl(Inline), Op]
        static ref readonly SegIndex offset(SegField i)
            => ref skip(segindices(),(byte)i);

        [MethodImpl(Inline), Op]
        static ref readonly SegMask segmask(SegField i)
            => ref skip(segmasks(), (byte)i);

        [MethodImpl(Inline), Op]
        static byte segval(PrimalKindBitField f, SegField i)
            => (byte)(((byte)segmask(i) & (byte)f.FieldValue) >> (int)offset(i));

        [MethodImpl(Inline), Op]
        static ref readonly SegField segfield(SegField i)
            => ref skip(segfields(),(byte)i);

        [MethodImpl(Inline), Op]
        static ref readonly SegWidth segwidth(SegField i)
            => ref skip(segwidths(), (byte)i);

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<SegIndex> segindices()
            => SegIndices;
        
        [MethodImpl(Inline), Op]
        static ReadOnlySpan<SegMask> segmasks()
            => SegMasks;

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<SegField> segfields()
            => SegFields;

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<SegWidth> segwidths()
            => SegWidths;

        static ReadOnlySpan<SegIndex> SegIndices
        {
            [MethodImpl(Inline)]
            get => cast<SegIndex>(FieldSegData);
        }

        static ReadOnlySpan<SegMask> SegMasks
        {
            [MethodImpl(Inline)]
            get => cast<SegMask>(FieldMaskData);
        }

        static ReadOnlySpan<SegField> SegFields
        {
            [MethodImpl(Inline)]
            get => cast<SegField>(FieldPartData);
        }

        static ReadOnlySpan<SegWidth> SegWidths
        {
            [MethodImpl(Inline), Op]
            get => Root.cast<SegWidth>(FieldWidthData);
        }

        static ReadOnlySpan<byte> FieldMaskData 
            => new byte[3]{(byte)SegMask.Width, (byte)SegMask.KindId, (byte)SegMask.Sign};

        static ReadOnlySpan<byte> FieldSegData
            => new byte[3]{(byte)SegIndex.Width, (byte)SegIndex.KindId, (byte)SegIndex.Sign};

        static ReadOnlySpan<byte> FieldPartData
            => new byte[3]{(byte)SegField.Width,(byte)SegField.KindId, (byte)SegField.Sign};

        static ReadOnlySpan<byte> FieldWidthData
            => new byte[3]{(byte)SegWidth.Width,(byte)SegWidth.KindId, (byte)SegWidth.Sign};
    }
}