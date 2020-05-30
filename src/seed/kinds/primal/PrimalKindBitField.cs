//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using FM = PrimalKindMask;
    using FS = PrimalKindSeg;
    using FX = PrimalKindIndex;
    using FK = PrimalKind;
    using FT = System.Byte;
    using BF = PrimalKindBitField;

    using API = PrimalKindBits;

    public readonly struct PrimalKindBitField : IPrimalBitField<BF, FX, FK, FS, FM, FT>
    {
        static API api => API.Service;

        internal readonly FK Data;

        public ReadOnlySpan<FM> Masks 
        {
            [MethodImpl(Inline)]
            get => Control.cast<FM>(MaskDefData);
        }

        public ReadOnlySpan<FS> Segments
        {
            [MethodImpl(Inline)]
            get => Control.cast<FS>(SegDefData);
        }

        ReadOnlySpan<byte> MaskDefData 
            => new byte[3]{(byte)FM.Width, (byte)FM.KindId,(byte)FM.Sign};

        ReadOnlySpan<byte> SegDefData
            => new byte[3]{(byte)FS.Width, (byte)FS.KindId, (byte)FS.Sign};

        [MethodImpl(Inline)]
        public static implicit operator FK(BF src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator BF(FK src)
            => new BF(src);

        [MethodImpl(Inline)]
        public static implicit operator FT(BF src)
            => (FT)src.Data;

        [MethodImpl(Inline)]
        public static implicit operator BF(FT src)
            => new BF(src);

        [MethodImpl(Inline)]
        public PrimalKindBitField(FK src)
            => Data = src;

        [MethodImpl(Inline)]
        public PrimalKindBitField(FT src)
            => Data = (PrimalKind)src;

        [MethodImpl(Inline)]
        public FM Mask(FX index)
            => api.mask(this, index);

        [MethodImpl(Inline)]
        public FS Segment(FX index)
            => api.segment(this, index);

        [MethodImpl(Inline)]
        public FT SegDataValue(FX index)
            => api.data(this, index);

        public FT this[FX index]
        {
            [MethodImpl(Inline)]
            get => api.data(this, index);
        }
    }
}